﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Radiation_project
{
    /// <summary>
    /// Interaction logic for FotoVoltaico.xaml
    /// </summary>
    public partial class FotoVoltaico : Window
    {

        DateTime start, end;
        Double lat, longi;
        public String currentItemText;
        List<String> fotoVoltaico = new List<String>();
        List<String> termoSolar = new List<String>();



        public FotoVoltaico(DateTime start, DateTime end, Double lat, Double longi)
        {
            InitializeComponent();
            this.start = start;
            this.end = end;
            this.lat = lat;
            this.longi = longi;
            this.fotoVoltaico = fotoVoltaico;
        }

        private void toModelo(object sender, RoutedEventArgs e)
        { 
            try
            {

                string selected = cmbProveedores.SelectedItems[0].ToString().Substring(37);

                cmbModelo.Items.Clear();
                cmdList.Items.Clear();
                termoSolar.Clear();
                cmdList.Items.Add("Marca: " + selected);
                termoSolar.Add(selected);

                if (selected.Equals("Orange Solar Power"))
                {

                    cmbModelo.Items.Add("OSP-SG270M");
                    cmbModelo.Items.Add("OSP-SG280M");
                    cmbModelo.Items.Add("OSP-OS280M");
                    cmbModelo.Items.Add("OSP-OS290M");
                    cmbModelo.Items.Add("OSP-OS300M");

                }
                if (selected.Equals("Resun Solar Energy"))
                {
                    cmbModelo.Items.Add("RS6S 295P");
                    cmbModelo.Items.Add("RS6S 300P");
                    cmbModelo.Items.Add("RS6S 305P");
                    cmbModelo.Items.Add("RS6S 310P");
                    cmbModelo.Items.Add("RS6S 315P");

                }

                if (selected.Equals("Changzhou GS Energy"))
                {
                    cmbModelo.Items.Add("235");
                    cmbModelo.Items.Add("240");
                    cmbModelo.Items.Add("245");
                    cmbModelo.Items.Add("250");
                    cmbModelo.Items.Add("255");
                    cmbModelo.Items.Add("260");
                }

                if (selected.Equals("CSG PVTech Co"))
                {
                    cmbModelo.Items.Add("290");
                    cmbModelo.Items.Add("295");
                    cmbModelo.Items.Add("300");
                    cmbModelo.Items.Add("305");
                    cmbModelo.Items.Add("310");
                    cmbModelo.Items.Add("315");
                    cmbModelo.Items.Add("320");
                }

                if (selected.Equals("Tamesol Desa S.L."))
                {
                    cmbModelo.Items.Add("TM-P672280");
                    cmbModelo.Items.Add("TM-P672285");
                    cmbModelo.Items.Add("TM-P672290");
                    cmbModelo.Items.Add("TM-P6722952");
                    cmbModelo.Items.Add("TM-P672300");

                }


                if (selected.Equals("Jiangsu Runda PV Co"))
                {
                    cmbModelo.Items.Add("RS240P-60");
                    cmbModelo.Items.Add("RS245P-60");
                    cmbModelo.Items.Add("RS250P-60");
                    cmbModelo.Items.Add("RS255P-60");
                    cmbModelo.Items.Add("RS260P-60");
                }

                if (selected.Equals("Sky Energy Indonesia"))
                {
                    cmbModelo.Items.Add("STM255");
                    cmbModelo.Items.Add("STM260");
                    cmbModelo.Items.Add("STM265");
                    cmbModelo.Items.Add("STM270");
                }

                if (selected.Equals("Anhui Daheng Energy Technology"))
                {
                    cmbModelo.Items.Add("30");
                    cmbModelo.Items.Add("50");
                    cmbModelo.Items.Add("70");
                    cmbModelo.Items.Add("80");
                    cmbModelo.Items.Add("100");

                }

                if (selected.Equals("Luxen Solar Energy Co"))
                {
                    cmbModelo.Items.Add("LNSE-250M");
                    cmbModelo.Items.Add("LNSE-255M");
                    cmbModelo.Items.Add("LNSE-260M");
                    cmbModelo.Items.Add("LNSE-2M65");
                    cmbModelo.Items.Add("LNSE-270M");
                }

                if (selected.Equals("Sun Electronics International"))
                {
                    cmbModelo.Items.Add("YL280P-35b");
                    cmbModelo.Items.Add("YL285P-35b");
                    cmbModelo.Items.Add("YL290P-35b");
                    cmbModelo.Items.Add("YL295P-35b");
                    cmbModelo.Items.Add("YL300P-35b");
                    cmbModelo.Items.Add("YL305P-35b");
                    cmbModelo.Items.Add("YL310P-35b");
                }

                if (selected.Equals("Infinity New Energy Co"))
                {
                    cmbModelo.Items.Add("INE-260-6MB");
                    cmbModelo.Items.Add("INE-265-6MB");
                    cmbModelo.Items.Add("INE-270-6MB");
                    cmbModelo.Items.Add("INE-275-6MB");
                }

                if (selected.Equals("Suzhou Suncome Solar Science"))
                {
                    cmbModelo.Items.Add("245");
                    cmbModelo.Items.Add("250");
                    cmbModelo.Items.Add("255");
                    cmbModelo.Items.Add("260");
                }

                if (selected.Equals("Jiangyin Shine Science and Tech"))
                {
                    cmbModelo.Items.Add("SS230-60M(Black)");
                    cmbModelo.Items.Add("SS235-60M(Black)");
                    cmbModelo.Items.Add("SS240-60M(Black)");
                    cmbModelo.Items.Add("SS245-60M(Black)");
                    cmbModelo.Items.Add("SS250-60M(Black)");

                }

                if (selected.Equals("Chinaland Solar Energy Co"))
                {
                    cmbModelo.Items.Add("220");
                    cmbModelo.Items.Add("230");
                    cmbModelo.Items.Add("235");
                    cmbModelo.Items.Add("240");
                    cmbModelo.Items.Add("245");
                    cmbModelo.Items.Add("250");
                    cmbModelo.Items.Add("255");
                    cmbModelo.Items.Add("260");
                }

                if (selected.Equals("Jetion Solar (China) Co"))
                {
                    cmbModelo.Items.Add("JT135SFc");
                    cmbModelo.Items.Add("JT140SFc");
                    cmbModelo.Items.Add("JT145SFc");
                    cmbModelo.Items.Add("JT150SFc");

                }



                if (selected.Equals("Econess Energy Co"))
                {
                    cmbModelo.Items.Add("EN 156P-72-300");
                    cmbModelo.Items.Add("EN 156P-72-305");
                    cmbModelo.Items.Add("EN 156P-72-310");
                    cmbModelo.Items.Add("EN156P-72-315");
                    cmbModelo.Items.Add("EN156P-72-320");
                }

                if (selected.Equals("YY Solar Co., Ltd."))
                {
                    cmbModelo.Items.Add("10");
                    cmbModelo.Items.Add("20");
                    cmbModelo.Items.Add("30");
                    cmbModelo.Items.Add("40");
                    cmbModelo.Items.Add("50");
                    cmbModelo.Items.Add("60");
                    cmbModelo.Items.Add("80");
                    cmbModelo.Items.Add("100");
                }
                if (selected.Equals("TN Solar"))
                {
                    cmbModelo.Items.Add("TN Solar 230P");
                    cmbModelo.Items.Add("TN Solar 235P");
                    cmbModelo.Items.Add("TN Solar 240P");
                    cmbModelo.Items.Add("TN Solar 245P");
                    cmbModelo.Items.Add("TN Solar 250P");
                }

                if (selected.Equals("Jinhua Dokio Technology Co."))
                {
                    cmbModelo.Items.Add("DSP80P-1");
                    cmbModelo.Items.Add("DSP80P-2");
                    cmbModelo.Items.Add("DSP240P-1");
                    cmbModelo.Items.Add("DS240P-2");
                    cmbModelo.Items.Add("DS290P");

                }

                if (selected.Equals("Risen Energy Co., Ltd."))
                {
                    cmbModelo.Items.Add("RSM72-6-300P");
                    cmbModelo.Items.Add("RSM72-6-300P");
                    cmbModelo.Items.Add("RSM72-6-310P");
                    cmbModelo.Items.Add("SYP310S");
                    cmbModelo.Items.Add("RSM72-6-315P");
                    cmbModelo.Items.Add("SYP315S");
                    cmbModelo.Items.Add("RSM72-6-320P");
                    cmbModelo.Items.Add("SYP320S");
                }

                if (selected.Equals("Infinity New Energy Co., Ltd."))
                {
                    cmbModelo.Items.Add("INE-250-6PB");
                    cmbModelo.Items.Add("INE-255-6PB");
                    cmbModelo.Items.Add("INE-260-6PB");
                    cmbModelo.Items.Add("INE-265-6PB");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

                MessageBox.Show("Se tiene que seleccionar una opción");

            }
        }

        private void toInversor(object sender, RoutedEventArgs e)
        {
            
            {

                string selected = cmbModelo.SelectedItems[0].ToString();
                string compA, compB, compC, compD, compE;

                compA = "HOSOLA Smart 3000TL";
                compB = "AERL SRMVW";
                compC = "Trojan Battery Company 27-Gel";
                compD = "CENTRON C1S";
                compE = "MONSOL Quick Domo";
                if (cmdList.Items.Count > 2)
                {
                    for (int i = 6; i>0;i--)
                    {
                        cmdList.Items.RemoveAt(i);
                        termoSolar.RemoveAt(i);
                    }


                }



                cmdList.Items.Add("Modelo: " + selected);
                cmdList.Items.Add("Inversor: " + compA);
                cmdList.Items.Add("Regulador: "+compB);
                cmdList.Items.Add("Bateria: "+compC);
                cmdList.Items.Add("Medidor Bidireccional: "+compD);
                cmdList.Items.Add("Sistena de monitorizacion: "+compE);

                termoSolar.Add(selected);
                termoSolar.Add(compA);
                termoSolar.Add(compB);
                termoSolar.Add(compC);
                termoSolar.Add(compD);
                termoSolar.Add(compE);







            }

        }

       
        }
    }

