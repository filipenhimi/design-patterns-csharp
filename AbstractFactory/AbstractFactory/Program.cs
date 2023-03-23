using AbstractFactory.Factory;

IGUIFactory factory;

factory = new WindowsFactory();
factory.createButton().Paint();
factory.createCheckbox().Paint();

factory = new MacFactory();
factory.createButton().Paint();
factory.createCheckbox().Paint();
