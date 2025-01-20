# The Liskov Substitution Principle (LSP), another SOLID principle, was introduced by Barbara Liskov. 
# It states that objects of a superclass should be replaceable with objects of its subclasses without affecting the correctness of the program. 
# That means a subclass should completely adhere to the behavior expected by the superclass. 
# The Liskov Substitution Principle encourages a design where subclasses are substitutable for their base classes.

# As you can see in the above example, Apple is the base class, and Orange is the child class, i.e., 
# there is a Parent-Child relationship. So, we can store the child class object in the Parent class Reference variable, i.e., Apple apple = new Orange(); 
# and when we call the GetColor, i.e., apple.GetColor(), then we are getting the color Orange, not the color of an Apple. 
# That means the behavior changes once the child object is replaced, i.e., Apple stores the Orange object. This is against the LSP Principle. 
# The Liskov Substitution Principle states that even if the child object is replaced with the parent, the behavior should not be changed. 

# So, in this case, if we are getting the color Apple instead of Orange, it follows the Liskov Substitution Principle. 