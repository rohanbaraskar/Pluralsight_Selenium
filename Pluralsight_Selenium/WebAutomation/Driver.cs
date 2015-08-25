﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }
    }
}