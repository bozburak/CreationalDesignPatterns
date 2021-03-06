﻿using BuilderPattern.Abstracts;
using BuilderPattern.Model;

namespace BuilderPattern.Models
{
    class Chrome : BrowserBuilder
    {
        BrowserModel browserModel = new BrowserModel();
        public override void GetBrowserName()
        {
            browserModel.Name = "Chrome";
        }

        public override void GetBrowserVersion()
        {
            browserModel.Version = "1.0";
        }

        public override BrowserModel Build()
        {
            return browserModel;
        }
    }
}