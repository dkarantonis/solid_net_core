# SOLID Principles

SOLID is an acronym for 5 important design principles when doing OOP (Object Oriented Programming) that intended to make software designs more understandable, flexible and maintainable. 

The theory of SOLID principles was introduced by Robert C. Martin (aka 'uncle Bob') in his 2000 paper 'Design Principles and Design Patterns', although the SOLID acronym was introduced later by Michael Feathers.


### S - Single responsibility principle (SRP)

* **State:** 'There should never be more than one reason for a class to change.'
* **Meaning:** Each software component (class, method or module) should be responsible for doing only one thing, and it should do that one thing really well.

* **Violation by:** Writing software components with multiple responsibilities.
* **Problem:** More responsibilities make component changes more frequent,  result in compatibility issues, components make harder to understand, increase the chance of introducing bugs.

* **Apply SRP:** More responsibilities make component changes more frequent,  result in compatibility issues, components make harder to understand, increase the chance of introducing bugs.
* **Benefits:** Single responsibility components result in code that is easer to understand, maintain and unit test.


### O - Open/closed principle (OCP)

* **State:** 'Software entities should be open for extension, but closed for modification.'
* **Meaning:** Design software entities in such a way that we then can easily add features, without having to modify, recompile and redeploy them.

* **Violation by:** Writing software components that need to modify when we need to introduce a change or a new feature.
* **Problem:** Modifying existing components may result in different behavior not expected by clients of the components, need to recompile & redeploy code that wastes time, introduces high chance of new bugs.

* **Apply OCP:** By using OO techniques like inheritance & polymorphism, by certain design patterns (like strategy patterns) or by plugin architecture.
* **Benefits:** This results in well-designed code and reduced risk of breaking code.


### L - Liskov substitution principle (LSP)

* **State:** 'If S is a subtype of T, then objects of type T may be replaced with objects of type S, without breaking the program.'
* **Meaning:** Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

* **Violation by:** Applying OO techniques like Inheritance and Polymorphism in a way that derived classes break 'contracts' of their parent classes.
* **Problem:** Modifying existing components may result in different behavior not expected by clients of the components, need to recompile & redeploy code that wastes time, introduces high chance of new bugs.

* **Apply LSP:** By making sure that new derived classes extend the base classes without changing their behavior.
* **Benefits:** This results in well-designed code that easily adopts new features and different implementations without affecting the existing code.


### I - Interface segregation principle (ISP)

* **State:** 'No client should be forced to depend on methods it does not use.'
* **Meaning:** Interfaces should serve a well-defined purpose and expose only purpose related specific functions.

* **Violation by:** Writing generic interfaces with multiple functions that do not need to be exposed to all clients.
* **Problem:** Clients need to implement functions they do not need, adding additional unnecessary complexity, risking the change to break compatibility with clients and to introduce new bugs.

* **Apply ISP:** By developing many smaller client specific interfaces rather than less generic ones.
* **Benefits:** This results in well-designed code with clear separation of responsibilities.


### D - Dependency inversion principle (DIP)

* **State:** 'High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.'
* **Meaning:** Components like classes should not depend on each other directly, they should rather depend on abstractions (like interfaces or abstract classes).

* **Violation by:** Writing classes that contain other classes via composition.
* **Problem:** Tight coupling among classes results in more complex code, harder to understand and maintain.

* **Apply ISP:** By replacing tight coupled class dependencies with loose coupled abstractions.
* **Benefits:** This results in well-designed code that supports the generic goals of high readability and maintainability.



## Additional Information

Additional information can be found on [SOLID wikipedia](https://en.wikipedia.org/wiki/SOLID).




