
using System;
using System.Collections.Generic;
using Design_pattern;

IComponent<string> component = new ConcreteComponent();
Console.WriteLine(component.GetText());

IComponent<string> plainDecorator = new PlainDecorator(component, "Hello, How are you? ");
Console.WriteLine(plainDecorator.GetText());

IComponent<string> colorDecorator = new ColorDecorator(component);
Console.WriteLine(colorDecorator.GetText());

IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
Console.WriteLine(upperCaseDecorator.GetText());
