# BOOTCAMP C# Formulatrix

## WEEK 1
> ### Day 1 - 31/07/2023 (Project 1)
- Set up
- Project structure
- Scratch Class Diagram untuk membuat variabel dan methods
- Class as a blueprint => object/instance

> ### Day 2 - 01/08/2023 (Project 2-5)
- Method with parameters inside
- Class ada variabel dan function/method

*__Function:__* <br>
```
public void myMethod()
```
- `public, private, protected, internal` => *_access modifier_*
- `void, int, string, bool` => *_return type_*
- `myMethod` => *_name_*
- `()` => *_parameter_*

*__About CONSTRUCTOR__ (Project 4)*
```
public class Lamp {
    public string? lampType;

    public Lamp(string LampType)
    {
	    this.lampType = LampType;
    }
}
```
- Special method untuk menginisialisasi object
- Constructors terpanggil saat object dibuat
- All classes have constructors by default, tapi tidak bisa set value
- Must match with the class name
- CanNOT have return type

*__4 PILAR OOP__*
- INHERITANCE (Project 5)

> ### Day 3 - 02/08/2023 (Project 6-7)
- Default access modifier pada class adalah internal

*__4 PILAR OOP__*
- ***ENCAPSULATION*** (Project 6)
    - `Public` => every class
    - `Private` => local hanya untuk parent
    - `Protected` => child bisa access dari parent tsb
    - `Internal` => project ada dll dan exe
    - `Protected internal`
- ***POLYMORPHISM*** (Project 7) => 1 bentuk berlaku pada bentuk yg lain
    - OVERLOAD
        ```
        int Add(int x, int y)
        string Add(string x, string y)
        ```
    - OVERRIDE
        - Child (override) tidak perlu mengikuti parent (virtual)

**LATIHAN MANDIRI** <br>
Inheritance - Encap - Poly aku gabung jd satu => Stranger Things

> ### Day 4 - 03/08/2023 (Project 8-12)

> ### Day 5 - 04/08/2023 (Project 13-16)


## WEEK 2
### Day 6 - 07/08/2023
### Day 7 - 08/08/2023
### Day 8 - 09/08/2023
### Day 9 - 10/08/2023
### Day 10 - 11/08/2023