using AgeOfLike.Factory.Model;
using AgeOfLike.Factory.Model.Batiment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgeOfLike.WPF.Model
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Forum forum;
        public Ressources mesRessources;
        public string Or { get; set; }
        public string Bois { get; set; }
        public string Pierre { get; set; }
        public string Nourriture { get; set; }
        public string Population { get; set; }

        private ICommand _IAjoutCaserne;
        private ICommand _IAjoutEcurie;
        private ICommand _IAjoutMaison;

        public MainWindowViewModel()
        {
            forum = new Forum();
            mesRessources = new Ressources();
            RefreshRessources();
            MaList = new ObservableCollection<Building>();
            MaList.Add(forum);

            Task task = new Task(() =>
            {
                while(true)
                {
                    if (mesRessources.Or < mesRessources.OrMax)
                    {
                        mesRessources.Or++;
                    }
                    if (mesRessources.Bois < mesRessources.BoisMax)
                    {
                        mesRessources.Bois++;
                    }
                    if (mesRessources.Nourriture < mesRessources.NourritureMax)
                    {
                        mesRessources.Nourriture++;
                    }
                    if (mesRessources.Pierre < mesRessources.PierreMax)
                    {
                        mesRessources.Pierre++;
                    }
                    Thread.Sleep(1500);
                    RefreshRessources();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Or)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bois)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Nourriture)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Pierre)));
                }          
            });

            task.Start();
        }

        private ObservableCollection<Building> _maList;
        public ObservableCollection<Building> MaList
        {
            get
            {
                return _maList;
            }

            set
            {
                _maList = value;
            }
        }

        private void AjoutCaserne()
        {
            if(mesRessources.Bois - new Caserne().Bois >= 0 && mesRessources.Pierre - new Caserne().Pierre >= 0)
            {
                MaList.Add(new Caserne());
                mesRessources.Bois -= new Caserne().Bois;
                mesRessources.Pierre -= new Caserne().Pierre;
            }  
        }

        private void AjoutEcurie()
        {
            if (mesRessources.Bois - new Ecurie().Bois >= 0 && mesRessources.Pierre - new Ecurie().Pierre >= 0)
            {
                MaList.Add(new Ecurie());
                mesRessources.Bois -= new Ecurie().Bois;
                mesRessources.Pierre -= new Ecurie().Pierre;
            }
        }

        private void AjoutMaison()
        {
            if (mesRessources.Bois - new Maison().Bois >= 0 && mesRessources.Pierre - new Maison().Pierre >= 0)
            {
                MaList.Add(new Maison());
                mesRessources.Bois -= new Maison().Bois;
                mesRessources.Pierre -= new Maison().Pierre;
                mesRessources.PopulationMax += new Maison().Population;
                RefreshRessources();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Population)));
            }
        }
        public ICommand IAjoutCaserne
        {
            get
            {
                if(_IAjoutCaserne == null)
                {
                    _IAjoutCaserne = new RelayCommand(AjoutCaserne);
                }
                return _IAjoutCaserne;
            }
        }
        public ICommand IAjoutEcurie
        {
            get { if(_IAjoutEcurie == null) { _IAjoutEcurie = new RelayCommand(AjoutEcurie); } return _IAjoutEcurie; }
        }
        public ICommand IAjoutMaison
        {
            get { if(_IAjoutMaison == null) { _IAjoutMaison = new RelayCommand(AjoutMaison); }return _IAjoutMaison; }
        }


        public void RefreshRessources()
        {
            Or = mesRessources.Or + "/" + mesRessources.OrMax + " Or";
            Bois = mesRessources.Bois + "/" + mesRessources.BoisMax + " Bois";
            Pierre = mesRessources.Pierre + "/" + mesRessources.PierreMax + " Pierre";
            Nourriture = mesRessources.Nourriture + "/" + mesRessources.NourritureMax + " Nourriture";
            Population = mesRessources.Population + "/" + mesRessources.PopulationMax + " Population";
        }

    }
}
