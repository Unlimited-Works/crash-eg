using UnityEngine;
using System.Collections;
using Lorance.RxScoket.Util;

public class testFlatMap : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Dog d = new Dog ();
		IOption<Dog> dogOpt = new Some<Dog> (d);

		//ok
		Dog dog = dogOpt.GetOrElse<Dog> (() => new Dog());

		//crash at this point. does it care about polymorphism? but it works on pure .net project
		Animal animal = dogOpt.GetOrElse<Animal> (() => new Cat());

		print ("r2 -" + animal);
	}
}

public class Animal {}
public class Dog: Animal {}
public class Cat: Animal {}
