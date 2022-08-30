using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    internal class Robots
    {
        //instans variable
        private ModelName model;
        private string color;
        private string chip;
        private string wifi;
        private string battery;
        private string soapContainer;
        private int batterySize;
        private int wheels;

        //encapsulation
        public ModelName Model { get => model; }
        public string Color { get => color; }
        public string Chip { get => Chip; }
        public string Wifi { get => wifi; }
        public string Battery { get => battery; }
        public string SoapContainer { get => soapContainer; }
        public int BatterySize { get => batterySize; }
        public int Wheels { get => wheels; }


        //random generator
        Random random = new Random();
        int thoose = new Random().Next(0, 2);


        //constructors
        private Robots()
        {

        }
        private Robots(string color) : this()
        {
            this.color = "white";
        }
        private Robots(string color, String chip) : this(color)
        {
            this.chip = thoose == 1 ? "RX54667" : "QT8339";
        }
        private Robots(string color, string chip, string wifi) : this(color, chip)
        {
            this.wifi = thoose == 1 ? "got wifi" : "no wifi";
        }
        private Robots(string color, string chip, string wifi, string battery) : this(color, chip,  wifi)
        {
            if (this.model == ModelName.Tire)
            {
                this.battery = "Got a battery";

                this.batterySize = thoose == 1 ? 128 : 255;
            }
        }
        private Robots(string color, string chip, string wifi, string battery, string soapContainer) : this(color, chip, wifi, battery)
        {
            if (this.model == ModelName.Romba || this.model == ModelName.WindowCleaner)
            {
                this.soapContainer = "this model has a soap contanier on 2,3L.";
            }
            else
            {
                this.soapContainer = "This model has no soap contanier.";
            }
        }
        private Robots(string color, string chip, string wifi, string battery, string soapContainer, int wheels) : this(color, chip, wifi, battery, soapContainer)
        {
            if (this.model != ModelName.Romba)
            {
                if (this.model == ModelName.WindowCleaner)
                {
                    this.wheels = 4;
                }
                else
                {
                    this.wheels = 6;
                }
            }
        }
        public Robots(string color, string chip, string wifi, string battery, string soapContainer, int wheels, ModelName model) : this(color, chip, wifi, battery, soapContainer,wheels)
        {
           this.model = model;  
        }

        public override string ToString()
        {
            return $"color: {color}\n chip: {chip} \n wifi: {wifi}\n battery: {battery}\n soap container: {soapContainer}\n whells: {wheels}\n model: {model}";
        }

    }
}
