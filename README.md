## Layered Object-Oriented-Design in `C#`

**This project is a lightweight C# reference implementation of the layer architectural pattern.**
  
Software layers are special dependency-related structures concerning packages, that align those packages in a way that all dependencies are linear. That means that each layer only relies on the next lower level layer.

Layers communicate with method calling and event passing. A low level package will report any events to upper-level subscribers. A higher level will always call a lower level directly. In C# this is pretty convenient due to the language having a built-in event system (a.k.a. Observer Pattern). That way, the developer can create interfaces that standardize communication in both ways: method calling and event passing.

Note that this is really just a bare sample of how it could be done. The single projects have been kept very simple, and the split between interfaces and classes would usually not be necessary with such a simple design. Yet i still did it to show how things are working. If the layers get more complex, you will need a standard interface for each one, so you know exactly how you can communicate with each layer.
