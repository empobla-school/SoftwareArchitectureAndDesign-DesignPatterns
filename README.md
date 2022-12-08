# Design Patterns (Software Architecture and Design)

## Author
* Emilio Popovits Blake (A01027265)

## Singleton
Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

### Example Functionality:
The implemented example shows how using the Singleton creational design pattern with a global database object would work, to prevent overwrites to the global database object and always return the same instance (prevent multiple instances).

## Factory Method
Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

### Example Functionality:
The implemented example shows how using the Factory Method creational design pattern with animals exemplifies how different animal subclasses can be created from a factory object creator superclass, implementing different methods that are the named the same.

## Abstract Factory
Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

### Example Functionality:
The implemented example shows how using the Abstract Factory creational design pattern helps produce different families of related objects with the same factories, implemented in a tech store use case where the tech store sells Apple and Google computers and phones.

## Builder
Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

### Example Functionality:
The implemented example shows how using the Builder creational design pattern implemented to a Laptop and Desktop computer generation use case helps reduce the different types of subclassing and helps prevent massive constructors on the related classes.

## Prototype
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

### Example Functionality:
The implemented example shows how using the Prototype creational design pattern in an Employee-object use case can easily create copies of the same object.

## Adapter
Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.

### Example Functionality:
The implemented example shows how using the Adapter structural design pattern implemented with a "third party vector library" is useful in order to convert data without modifying the client codebase and without modifying the third party library.

## Resources
https://refactoring.guru/design-patterns/adapter