﻿namespace Selenium.WebDriver.Extensions.IntegrationTests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "ExceptionNotDocumentedOptional")]
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    public class FirefoxFixture : IDisposable
    {
        private bool disposed;

        public FirefoxFixture()
        {
            this.Browser = new FirefoxDriver();
        }

        ~FirefoxFixture()
        {
            this.Dispose(false);
        }

        public IWebDriver Browser { get; }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        [SuppressMessage(
            "Microsoft.Usage",
            "CA2213:DisposableFieldsShouldBeDisposed",
            MessageId = "<Browser>k__BackingField")]
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed || !disposing)
            {
                return;
            }

            this.Browser.Dispose();
            this.disposed = true;
        }
    }
}
