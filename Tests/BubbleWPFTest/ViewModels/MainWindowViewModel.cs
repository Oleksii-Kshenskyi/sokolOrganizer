
using BubbleWPFTest.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleWPFTest.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна
        
        private string _Title = "BubbleWPFTest заголовок";
        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            //set
            //{   //Полный код
            //    //if (Equals(_Title, value)) return;
            //    //_Title = value;
            //    //OnPropertyChanged();

            //    //Сокращенный код
            //    //Set(ref _Title, value);
            //}
            set => Set(ref _Title, value);
        } 
        #endregion
    }
}
