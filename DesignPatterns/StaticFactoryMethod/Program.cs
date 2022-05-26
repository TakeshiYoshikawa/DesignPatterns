using StaticFactoryMethod;

RandomIntGenerator rig = RandomIntGenerator.LowerThan(100);
RandomIntGenerator rig2 = RandomIntGenerator.Between(30, 40);

Console.WriteLine(rig.min);
Console.WriteLine(rig2.min);