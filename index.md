---
layout: default
title: Selenium WebDriver Extensions | selenium-webdriver-extensions | RaYell's GitHub
---

# Description
Extensions for Selenium WebDriver.

# Features
* Main
 * Support for nested selectors
 * Very easy setup: install packages with NuGet and start using it with your existing Selenium solution
 * High quality ensured by continuous integration setup with Appveyor, unit and integration testing and high code coverage
 * Well documented code following strict StyleCop and FxCop rules
* jQuery support
 * jQuery selectors support for Selenium WebDriver to perform DOM-element selections that CSS can't do
 * jQuery auto-load on pages on sites that don't use jQuery
 * Support for jQuery context switching
 * Support for `ExpectedConditions` with jQuery selectors
 * Support for Page Objects with jQuery selectors
* Sizzle support
 * Sizzle selectors support for Selenium WebDriver to perform DOM-element selections that CSS can't do
 * Sizzle auto-load on pages on sites that don't use Sizzle
 * Support for Sizzle context switching
 * Support for `ExpectedConditions` with Sizzle selectors
 * Support for Page Objects with Sizzle selectors

# Installation
Run the following command in Visual Studio Packet Manager Console.

{% highlight powershell %}
Install-Package Selenium.WebDriver.Extensions
{% endhighlight %}

# Documentation
API documentation can be found [here](https://rayell.github.io/selenium-webdriver-extensions/api) and user guide is on the [wiki](https://github.com/RaYell/selenium-webdriver-extensions/wiki).

# Usage

## Include extensions
Create alias for the extension `By` to be used.

{% highlight csharp %}
using By = OpenQA.Selenium.Extensions.By;
{% endhighlight %}

If you don't want to override the `By` to be used, you can always create `JQuerySelector` and `SizzleSelector` instances with `new` keyword.

## Basic jQuery example
Invoke jQuery selectors on the WebDriver.

{% highlight csharp %}
driver.FindElements(By.JQuerySelector("input:visible"))
{% endhighlight %}

## Chaining jQuery methods
You can also chain jQuery traversing methods.

{% highlight csharp %}
var selector = By.JQuerySelector("div.myclass").Parents(".someClass").NextAll();
driver.FindElement(selector);
{% endhighlight %}

## jQuery loading
If the site that you are testing with Selenium does not include jQuery this extension will automatically load the latest version when you run `FindElement` or `FindElements` method. If you want you can choose to load a different version of jQuery.

{% highlight csharp %}
driver.LoadJQuery("1.11.0");
{% endhighlight %}

## jQuery variable name
When you create a jQuery selector using `By` helper class the resulting selector will use `jQuery` as library variable name. If you site is using a different variable name for this purpose you can pass this value as an optional parameter.

{% highlight csharp %}
var selector = By.JQuerySelector("div", jQueryVariable: "myJQuery");
{% endhighlight %}

## jQuery context switch
You can use one `JQuerySelector` instance as a context of another `JQuerySelector`.

{% highlight csharp %}
var context = By.JQuerySelector("div.myClass");
var selector = By.JQuerySelector("ol li", context);
driver.FindElements(selector);
{% endhighlight %}

## Basic Sizzle example
Invoke Sizzle selectors on the WebDriver.

{% highlight csharp %}
driver.FindElements(By.SizzleSelector("input:visible"))
{% endhighlight %}

## Sizzle loading
If the site that you are testing with Selenium does not include Sizzle this extension will automatically load the latest version when you run `FindElement` or `FindElements` method. If you want you can choose to load a different version of jQuery.

{% highlight csharp %}
driver.LoadSizzle("1.11.1");
{% endhighlight %}

## Sizzle context switch
You can use one `SizzleSelector` instance as a context of another `SizzleSelector`.

{% highlight csharp %}
var context = By.SizzleSelector("div.myClass");
var selector = By.SizzleSelector("ol li", context);
driver.FindElements(selector);
{% endhighlight %}
