﻿using System;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace NeoSharp.Client.DI
{
    public static class ClientPackage
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IClientManager, ClientManager>(Lifestyle.Singleton);
            container.Register<IPrompt, Prompt>(Lifestyle.Singleton);
            container.Register<IConsoleReader, ConsoleReader>(Lifestyle.Singleton);
            container.Register<IConsoleWriter, ConsoleWriter>(Lifestyle.Singleton);
        }     
    }

}