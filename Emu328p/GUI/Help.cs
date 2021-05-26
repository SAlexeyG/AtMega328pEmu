﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();
		}

		private void Help_Load(object sender, EventArgs e)
		{
			textBox.Text = "\r\nДля первого входа в приложение необходимо зарегистрироваться. После нажатия кнопки «Зарегистрироваться» будет открыто окно входа. " +
				"\r\nЕсли вы забыли пароль следует нажать на надпись «Забыли пароль?», в таком случае на введенную при регистрации почту придет код, который следует вставить в окно смены пароля.Если код не пришел нажмите на надпись «Не пришел код ?» и попытка отправки кода будет повторена." +
				"\r\nлавная форма, на которой содержатся кнопки – пункты меню:" +
				"\r\n–	«Файл»;" +
				"\r\n–	«Окно»;" +
				"\r\n–	«Пуск»;" +
				"\r\n–	«Стоп»." +
				"\r\nВ пункте меню «Окно» перечислены окна, которые можно открыть. Открытие окна происходит при нажатии на соответствующий пункт меню.Закрываются окна при повторном нажатии." +
				"\r\nПри выборе на главной форме кнопки(«Файл -> Открыть…»), откроется форма с выбором файла программы." +
				"\r\nПри выборе файла на главном окне появятся команды для микроконтроллера и станет доступной кнопка «Пуск»." +
				"\r\nПри выборе кнопки «Пуск» можно заметить, что микроконтроллер запущен. При переходе в окно UART можно увидеть данные, отправленные микроконтроллером." +
				"\r\nПри выборе на форме «Стоп» выполнение программы остановится." +
				"\r\nНа верхней панели можно выбрать тип запуска «Отладка»." +
				"\r\nПри выборе на форме кнопки «Пуск» данная кнопка будет заменена на кнопку «Далее», а в окне прошивки появится выделенная команда." +
				"\r\nПри нажатии на кнопку «Далее» выделенная команда выполнится и выделится следующая команда." +
				"\r\nОстановить отладку можно нажатием кнопки «Стоп»." +
				"\r\nПри изменении данных в личном кабинете станет доступна кнопка «Изменить». При нажатии на эту кнопку изменения применятся, и кнопка снова станет неактивной.";
		}
	}
}