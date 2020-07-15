using CarSellingDAL.DAL;
using CarSellingDAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelling
{
    public partial class frmPosAd : Form
    {
        List<string> lstImagesPathes = new List<string>();
        string path = @"D:\desrler\Layiheler\TurboAz\Images ";
        CarDal carCrud;
        ImageDal imageCrud;
        CommonDal common;

      
        public frmPosAd()
        {
            InitializeComponent();
            common = new CommonDal();
            carCrud =new CarDal();
            imageCrud =new ImageDal();
            cbMarka.DataSource = common.GetBrandsByIdName();
            cbMarka.SelectedIndex = -1;
            
            cbBodyType.DataSource = common.GetBanTypesByIdName();
            cbBodyType.SelectedIndex = -1;
            cbColor.DataSource = common.GetColorsByIdName();
            cbColor.SelectedIndex = -1;
            cbFuelType.DataSource = common.GetFuelTypesByIdName();
            cbFuelType.SelectedIndex = -1;
            cbGearBox.DataSource = common.GetGearboxTypesByIdName();
            cbGearBox.SelectedIndex = -1;
            cbTransmission.DataSource = common.GetTansmitionTypesByIdName();
            cbTransmission.SelectedIndex = -1;
            cbEngineCapacity.DataSource = common.GetEngineCapacitiesByIdName();
            cbEngineCapacity.SelectedIndex = -1;
            cbCity.DataSource = common.GetCityByIdName();
            cbCity.SelectedIndex = -1;

        }



        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            car.BrandId = Convert.ToInt32(cbMarka.SelectedValue);
            car.ModelId = Convert.ToInt32(cbModel.SelectedValue);

            car.ColorId = Convert.ToInt32(cbColor.SelectedValue);
            car.Price = Convert.ToDecimal(txtPrice.Text);
            car.FuelTypeId = Convert.ToInt32(cbFuelType.SelectedValue);
            car.TransmitionTypeId = Convert.ToInt32(cbTransmission.SelectedValue);
            car.GearboxTypeId = Convert.ToInt32(cbGearBox.SelectedValue);
            // car.ManifactureDate = Convert.ToDateTime(cbManifactureDay.SelectedValue);
            car.ManifactureDate = Convert.ToDateTime(dateTimePicker1.Value);
            car.EngineCapaciyId = Convert.ToInt32(cbEngineCapacity.SelectedValue);
            car.EnginePower = Convert.ToInt32(txtEnginePower.Text);
            car.AZN = rdbAzn.Checked;
            car.USD = rbtDollar.Checked;
            car.EURO = rbtEureo.Checked;
            car.Description = richTextBox1.Text;

            car.AlloyWheels = ckAlloyWheels.Checked;
            car.CentralClosure = ckCenralClosure.Checked;
            car.LeatherSalon = ckLeatherSalon.Checked;

            car.SeatVentilation = ckSeatVentilation.Checked;
            car.ABS = ckABS.Checked;
            car.ParkingRadar = ckParkingRadar.Checked;
            car.KsenonLamps = ckKsenonLamps.Checked;
            car.Lyuk = ckLyuk.Checked;
            car.Conditioner = ckConditioner.Checked;
            car.RearViewCamera = ckRainSensor.Checked;
            car.RainSensor = ckRainSensor.Checked;
            car.SeatHeating = ckSeatHeating.Checked;
            car.SideCurtains = ckSideCurtains.Checked;
            car.UserId = 2;
            car.BanTypeId = Convert.ToInt32(cbBodyType.SelectedValue);
            car.CitiId = Convert.ToInt32(cbCity.SelectedValue);
            car.Kilometerage = Convert.ToInt32(txtDriving.Text);
            int carId =  carCrud.Insert(car);
            carId = carCrud.GetLastId();

            foreach (var item in lstImagesPathes)
            {
                string format = item.Substring(item.IndexOf('.'));
                string yol = path + "\\" + Guid.NewGuid() + format;

                System.IO.File.Copy(item, yol);
                CarImages image = new CarImages();
                image.CarId = carId;
                image.Url = yol;
                imageCrud.Insert(image);
            }

            MessageBox.Show("Qeydiyyat üğürla başa çatdı");
        }
       

        private void cbMarka_SelectedValueChanged(object sender, EventArgs e)
        {
            int brandId = Convert.ToInt32(cbMarka.SelectedValue);

            cbModel.DataSource = common.GetModelByBrandIdName(brandId);
            cbModel.SelectedIndex = -1;
        }

        private void txtEnginePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDriving_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
             
        int x = 759;
        int coutPicturebox = 0;
        //   D:\desrler\Layiheler\TurboAz\Images
        List<string> imagePaths = new List<string>();

        private void btnAddImage_Click(object sender, EventArgs e)
        {
          
            try
            {
                
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png) |*.png| All Fiiles(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (coutPicturebox < 8)
                    {

                        var picture = new PictureBox
                        {

                            Size = new Size(100, 80),
                            Location = new Point(x, 19),
                            Image = Image.FromFile(dialog.FileName),
                            SizeMode = PictureBoxSizeMode.StretchImage

                        };
                        x = x - 105;
                        grbImages.Controls.Add(picture);
                        coutPicturebox++;
                        lstImagesPathes.Add(dialog.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Maksimum 8 sekil elave ede bilersiniz ");
                    }

                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
