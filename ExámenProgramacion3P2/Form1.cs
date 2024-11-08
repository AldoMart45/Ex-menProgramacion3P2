using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ExámenProgramacion3P2
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        private MySqlConnection dbConnection;

        public Form1()
        {
            InitializeComponent();
            // Configura el puerto serie
            serialPort = new SerialPort("COM3", 9600);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            dbConnection = new MySqlConnection("server=localhost;database=Exapractico3;uid=root;pwd=VeMartz45;");
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string[] values = data.Split(',');

            if (values.Length == 3)
            {
                Invoke(new Action(() =>
                {
                    lblCelsius.Text = $"Celsius: {values[0]} °C";
                    lblFahrenheit.Text = $"Fahrenheit: {values[1]} °F";
                    lblRawValue.Text = $"Raw: {values[2]}";

                    // Guardar las temperaturas en la base de datos
                    GuardarTemperatura(float.Parse(values[0]), float.Parse(values[1]), int.Parse(values[2]));
                }));
            }
        }

        // Método para guardar temperaturas en la base de datos
        private void GuardarTemperatura(float celsius, float fahrenheit, int rawValue)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Temperaturas (Celsius, Fahrenheit, RAWValue) VALUES (@celsius, @fahrenheit, @rawValue)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@celsius", celsius);
                cmd.Parameters.AddWithValue("@fahrenheit", fahrenheit);
                cmd.Parameters.AddWithValue("@rawValue", rawValue);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar temperatura: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        // Método para guardar el estado del LED y Servomotor en la base de datos
        private void GuardarEstadoControl(string dispositivo, bool estado)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Controles (ServoEstado, LEDEstado) VALUES (@servo, @led)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@servo", dispositivo == "Servo" ? (estado ? 1 : 0) : 0);
                cmd.Parameters.AddWithValue("@led", dispositivo == "LED" ? (estado ? 1 : 0) : 0);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar estado de control: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void lblRawValue_Click(object sender, EventArgs e)
        {

        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("L");
            GuardarEstadoControl("LED", true);
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("l");
            GuardarEstadoControl("LED", false);
        }

        private void btnServoOn_Click(object sender, EventArgs e)
        {
            serialPort.Write("S");
            GuardarEstadoControl("Servo", true);
        }

        private void btnServoOff_Click(object sender, EventArgs e)
        {
            serialPort.Write("s");
            GuardarEstadoControl("Servo", false);
        }

        private void btnReadTemperature_Click(object sender, EventArgs e)
        {
            serialPort.Write("T");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
            dbConnection.Dispose();
        }

        // Almacena el nombre de usuario y la fecha en la base de datos
        private void GuardarUsuario(string nombre, string fecha)
        {
            try
            {
                dbConnection.Open();
                string query = "INSERT INTO Usuarios (Nombre, Fecha) VALUES (@nombre, @fecha)";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(fecha));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                txtNombre.Text = string.Empty;
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFecha.Text, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$"))
            {
                // 
            }
            else
            {
                // 
                // 
            }
        }

        private void btnGuardarUsuario_Click_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fecha = txtFecha.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(fecha))
            {
                GuardarUsuario(nombre, fecha);
                MessageBox.Show("Usuario guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Completa todos los campos de nombre y fecha.");
            }
        }
    }
}
