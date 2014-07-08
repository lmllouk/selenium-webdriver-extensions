---
layout: default
title: Selenium WebDriver Extensions | selenium-webdriver-extensions | RaYell's GitHub
---

# Description

Extensions for Selenium WebDriver including jQuery selector support for FindElement and FindElements methods.

# Installation

Run the following command in Visual Studio's Packet Manager Console.

{% highlight powershell %}
Install-Package Selenium.WebDriver.Extensions
{% endhighlight %}

# Usage

Include extensions namespace and set the derived By to be used.

{% highlight c# %}
using Selenium.WebDriver.Extensions;
using By = Selenium.WebDriver.Extensions.By;
{% endhighlight %}

Invoke jQuery selectors on the WebDriver.

{% highlight c# %}
driver.FindElements(By.JQuerySelector("input:visible"))
{% endhighlight %}
