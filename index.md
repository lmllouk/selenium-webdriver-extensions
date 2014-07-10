---
layout: default
title: Selenium WebDriver Extensions | selenium-webdriver-extensions | RaYell's GitHub
---

# Description
Extensions for Selenium WebDriver including jQuery selector support for `FindElement` and `FindElements` methods.

# Features
Some of the most important features of this library include:
* Generates jQuery selectors that can be used by Selenium WebDrivers to perform searches that CSS can't do
* Allows jQuery selectors to be used even on sites that don't use jQuery as it can load before performing a first search
* Very easy setup: install package with NuGet, include a namespace and start using it
* Supports jQuery traversing methods for generation of complex selector chains
* Supports jQuery context switching
* CI with Appveyor
* 100% code coverage with nUnit tests
* Well documented code following strict StyleCop and FxCop rules.

# Installation
Run the following command in Visual Studio Packet Manager Console.

{% highlight powershell %}
Install-Package Selenium.WebDriver.Extensions
{% endhighlight %}

# Usage

## Include extensions
Include extensions namespace and set the derived `By` to be used.

{% highlight csharp %}
using Selenium.WebDriver.Extensions;
using By = Selenium.WebDriver.Extensions.By;
{% endhighlight %}

## Basic example
Invoke jQuery selectors on the WebDriver.

{% highlight csharp %}
var driver = new ChromeDriver();
driver.FindElements(By.JQuerySelector("input:visible"))
{% endhighlight %}

## Chaining
You can also chain jQuery traversing methods.

{% highlight csharp %}
var driver = new ChromeDriver();
var selector = By.JQuerySelector("div.myclass").Parents(".someClass").NextAll();
driver.FindElement(selector);
{% endhighlight %}

## jQuery loading
If the site that you are testing with Selenium does not include jQuery this extension will automatically load the latest version when you run `FindElement` or `FindElements` method. If you want you can choose to load a different version of jQuery.

{% highlight csharp %}
var driver = new ChromeDriver();
driver.LoadJQuery("1.11.0");
{% endhighlight %}

## jQuery variable name
When you create a jQuery selector using `By` helper class the resulting selector will use `jQuery` as library variable name. If you site is using a different variable name for this purpose you can pass this value as an optional parameter.

{% highlight csharp %}
var driver = new ChromeDriver();
var selector = By.JQuerySelector("div", jQueryVariable: "myJQuery");
{% endhighlight %}

## jQuery context switch
You can use one `JQuerySelector` as a context of another `JQuerySelector`.

{% highlight csharp %}
var driver = new ChromeDriver();
var context = By.JQuerySelector("div.myClass");
var selector = By.JQuerySelector("ol li", context);
driver.FindElements(selector);
{% endhighlight %}
