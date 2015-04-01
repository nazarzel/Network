using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public static bool isJson = false;
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
        }

        public class Car
        {
            public string Producer;
            public string Model;

            public Car()
            {

            }


            public Car(string producer, string model)
            {
                Producer = producer;
                Model = model;
            }

            public string PRODUCER { get; set; }
            public string MODEL { get; set; }



        }

        public void SerializeXml()
        {
            try
            {


                XmlSerializer serializer = new XmlSerializer(typeof(Car));
                Car car1 = new Car();
                car1.PRODUCER = "Mitsubishi";
                car1.MODEL = "L200";
                TextWriter writer = new StreamWriter(@"C:\Users\Назар\Desktop\abc.txt");
                serializer.Serialize(writer, car1);
                writer.Close();
                MessageBox.Show("Serialized");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeserializeXml()
        {
            try
            {
                Car car1 = new Car();
                XmlSerializer serializer = new XmlSerializer(typeof(Car));
                TextReader reader = new StreamReader(@"C:\Users\Назар\Desktop\abc.txt");
                car1 = (Car)serializer.Deserialize(reader);
                tbx_Data.Text = "Producer " +
                    car1.PRODUCER + "\n" + "Model " + car1.MODEL;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SerializeJSON()
        {
            Car car1 = new Car();
            car1.PRODUCER = "Mitsubishi";
            car1.MODEL = "L200";

            MemoryStream stream = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Car));
            ser.WriteObject(stream, car1);
            stream.Position = 0;
            StreamReader sr = new StreamReader(stream);
            tbx_Data.Text = "JSON form of Car object:\n";
            tbx_Data.Text += sr.ReadToEnd() + "\n";
            stream.Position = 0;
            Car human1 = (Car)ser.ReadObject(stream);
            tbx_Data.Text += "\n------Deserialized--------\n";
            tbx_Data.Text += "Producer: " + car1.PRODUCER + "\n";
            tbx_Data.Text += "Model: " + car1.MODEL + "\n";

            stream.Close();
            sr.Close();
        }

        private void rb_Json_CheckedChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            tbx_Data.Text = "";
            isJson = true;
        }

        private void rb_Xml_CheckedChanged(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnEnd.Enabled = true;
            tbx_Data.Text = "";
            isJson = false;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DeserializeXml();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isJson == true)
            {
                SerializeJSON();
            }
            else
            {
                SerializeXml();
            }
        }
    }
}
