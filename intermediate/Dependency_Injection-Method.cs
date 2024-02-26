﻿/*
Dependency Injection - method injection
 Dependency Injection (DI) is a design pattern used in programming and OOP design to reduce the dependency between objects. 
 It's a form of Inversion of Control (IoC) that allows an object to receive other objects it depends on. 
 These other objects are called dependencies.

 DI is used to make code more flexible, easier to test, and to separate concerns. 
 It can be done in three ways: constructor injection, property injection, and method injection.
 The following example is a simple demonstration of method dependency injection.
*/


class Restaurant
{
    private bool _open;

    public void OpenorClosed()
    {
        Console.WriteLine(_open ? "We are open" : "We are closed");
    }

    public void SetOpenorClosed(bool open)
    {
        _open = open;
    }
}


class RussBurgers
{
    public void CloseRestaurant(Restaurant restaurant)
    {
        restaurant.SetOpenorClosed(false);
    }

    public void OpenRestaurant(Restaurant restaurant)
    {
        restaurant.SetOpenorClosed(true);
    }

    public void AreYouOpen(Restaurant restaurant)
    {
        restaurant.OpenorClosed();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new();
        RussBurgers burgerplace = new();

        burgerplace.OpenRestaurant(restaurant);
        burgerplace.AreYouOpen(restaurant);
        burgerplace.CloseRestaurant(restaurant);
        burgerplace.AreYouOpen(restaurant);
    }
}