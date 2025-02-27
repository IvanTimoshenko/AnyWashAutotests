﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace AnyWashAutotests.Elements
{
    /// <summary>
    /// Специальный класс с переработанными методами для Selenium - "Кнопки"
    /// </summary>
    public class Button : Element
    {
        public Button(By by) : base(by) { }
        public Button(string xpath) : base(xpath) { }

        /// <summary> Поиск элемента по локатору и клик по нему </summary>
        /// <param needSwitching = "bool">Нужно ли переключаться на новую вкладку</param>
        public void Click(bool needSwitching = false, params object[] param)
        {
            var currentTabs = Hooks.WebDriver.Driver.WindowHandles;                               // получаем текущие вкладки

            // Пытаемся кликнуть
            if (!Click())
            {
                Hooks.WebDriver.Driver.FindElement(GetByLocator(param)).Click();
            }

            if (needSwitching)
            {
                Thread.Sleep(1000);
                string newTab = Hooks.WebDriver.Driver.WindowHandles.Except(currentTabs).First();     // получаем новую вкладку
                Hooks.WebDriver.Driver.SwitchTo().Window(newTab);                                     // переключаемся на новую вкладку
            }

            bool Click()
            {
                for (var sw = Stopwatch.StartNew(); sw.Elapsed < Config.WebDriverWait;)
                {
                    var element = FindElement(param);
                    Hooks.WebDriver.Wait.Until(ExpectedConditions.ElementToBeClickable(element));
                    try
                    {
                        element.Click();
                        return true;
                    }
                    catch (Exception) { }
                }
                return false;
            }
        }
    }
}
