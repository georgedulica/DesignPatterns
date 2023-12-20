# DesignPatterns

Behavioral design patterns:


Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing. It maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.




Creational design patterns:


Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
The Singleton pattern solves two problems at the same time, violating the Single Responsibility Principle:
1. Ensure that a class has just a single instance 
2. Provide a global access point to that instance
 
Factory is a creational design pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created.
The Factory Design Pattern is a versatile and widely used pattern that helps address several important problems in software development:
1. Reducing Coupling: You can change the concrete classes or add new ones without affecting existing code, adhering to the open-closed principle.
2. Object Creation Complexity: When creating objects involves intricate initialization or configuration, using a factory allows you to encapsulate this complexity within a dedicated class, making the client code simpler and more readable.

Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes. Some advantages of prototype design pattern are:
1. Object Creation Flexibility: Prototypes allow you to create new objects by copying existing ones, providing flexibility in object creation.
2. Encapsulation of Complexity: The prototype itself encapsulates the details of how its clones are created. This can hide the complexity of the object creation process from the client code.