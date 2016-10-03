using System;
using System.Collections.Generic;
using System.Text;
using Presenters;

namespace Logic_DataPicker.Presenters
{
    class MainPresenter : IPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
