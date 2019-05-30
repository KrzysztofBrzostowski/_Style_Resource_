using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using System.Windows;

namespace Comanding
{
	public class Model : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ICommand ButtonPressedCommand
		{
			get
			{
				return m_ButtonPressedCommand;
			}
			private set
			{
				if (m_ButtonPressedCommand != value)
				{
					m_ButtonPressedCommand = value;
					RaisePropertyChanged("ButtonPressedCommand");
				}
			}
		}
		private ICommand m_ButtonPressedCommand;

		public Model()
		{
			ButtonPressedCommand = new DelegateCommand(OnButtonPressedCommand);
		}

		private void OnButtonPressedCommand()
		{
			MessageBox.Show("OnButtonPressedCommand executed.");
		}

		private void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
