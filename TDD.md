# TDD Introductie

## Onderwerpen

- Inleiding: Canonicalizer
- Wat is TDD en waarom hebben we het nodig?    
- Misverstanden over TDD.
- Wat is "red-green-refactor"
- De drie geboden van TDD
- TDD en unit tests
- Wanneer faalt TDD?
- Code rot, SOLID
- TDD Dojo
- Meer leren en verder lezen.


## Inleiding
In deze introductie zal ik de basis van TDD bespreken ondersteund met informatie over unit testing. Unit tests zijn niet de enige vorm van automated testing die helpen de kwaliteit van code hoog te houden. Andere vormen zal ik kort benoemen, maar niet in detail behandelen.

Voorbeeld implementatie "canonicalizer" zonder tests met introductie van bugs.

## Wat is TDD en waarom hebben we het nodig?

TDD is een vorm van "test first development", dit betekent dat de ontwikkeling van software gedreven wordt door het schrijven van tests i.p.v. door het schrijven van de implementatie. Deze manier van ontwikkelen wordt ook gezien als "Test Driven Design", in kleine stappen bepaal je wat de invoer en het resultaat van je software is en schrijf je tests die verifieren dat de software dit blijft doen onder veranderende eisen of door refactoring. De unit tests die het resultaat zijn van TDD vormen daarmee de specificatie en documentatie van je software.

TDD helpt bij het vermijden van complexiteit, "gold plating", te vroeg optimalisatie.

## Misverstanden

- Het schrijven van tests verdubbeld de tijd die nodig is om resultaat te behalen.
- Je kunt geen tests schrijven als er geen ontwerp is.
- Je moet alle tests schrijven voor je begint met de implementatie.

TDD en software bouwen in het algemeen is een empirisch proces waarbij je voortdurend oplossingen verkend, toets en herziet. Faal snel en vaak.

## Red-Green-Refactor

TDD bestaat grotendeels uit herhaal de red-green-refactor fases doorlopen, dit ziet er als volgt uit.

- Red: maak een falende test
- Green: schrijf net genoeg code om je test te laten slagen
- Refactor: herzie je testcode en productiecode 

Herhaal dit door nieuwe tests te schrijven, tests te herzien. Net zo lang tot de implementatie van de productiecode voldoet aan alle verwachtingen, houdt er rekening mee dat deze verwachtingen kunnen veranderen gedurende dit proces. 

voorbeeld: Canonicalizer

## De drie geboden van TDD

1. Schrijf nooit ook maar 1 regel productiecode voordat je een falende test hebt geschreven.
2. Schrijf de meest minimale test die de code laat falen
3. Schrijf de meest minimale code om de test te laten slagen

Deze drie regels helpen je om gefocussed te blijven op het doel, om te voorkomen overgecompliceerde code te schrijven en de kwaliteit van code hoog te houden.

## Code rot, code smells en desig smells
Zonder testen is code onderhevig en vele vormen van verotting die ervoor zorgen dat de kwaliteit van de software afneemt, fouten in de software toenemen en de kosten van onderhoud en uitbreiding toeneemt. We kunnen de volgende vormen van dit soort "rot" onderscheiden.

- **Rigidity**: Zelfs de kleinste wijziging kosten veel tijd om door te voeren.
- **Fragility (Regression)**: Kleine wijziging in een module zorgen voor bugs in andere delen van het systeem. 
- **Immobility**: Hergebruik van code is onmogelijk of kostbaar
- **Viscosity**: Simpele aanpassingen vereist aanpassingen op vele vlakken en in vele lagen, zoals infrastructuur, database, frontend etc. 
- **Needless complexity**: Software waarin wordt geprobeerd alles af te hangen wat eventueel zou kunnen gebeuren waarbij er vele uitbreidingen ontstaan om die siuaties af te kunnen handelen.

Al deze vormen zijn vaak te herleiden naar wat tight coupling wordt genoemd, een harde afhankelijkheid tussen verschillende onderdelen van een geautomatiseerd systeem.

### SOLID

- Single Responsibility Principle
- Open/Closed Principle
- Liskov Subsitition Principle
- Interface Segregation Principle
- Dependency Inversion Principle

SOLID is geen doel, maar een middel om de software te schrijven die zoveel mogelijk "loosely coupled" is en daarmee goed testbaar en dus onderhoudbaar en aanpasbaar.

### Hoe helpen tests?

Tests vormen je vangnet. Tests zorgen ervoor dat je niet bang hoeft te zijn.

## TDD Dojo
### Katas
- FizzBuzz kata: https://codingdojo.org/kata/FizzBuzz/


### Meer leren en verder lezen
**Websites**

**Boeken**
- Test Driven Development: By Example, Kent Beck: https://www.amazon.com/Test-Driven-Development-Kent-Beck/dp/0321146530
- Unit Testing, Vladimir Khorikov: https://www.amazon.com/Unit-Testing-Principles-Practices-Patterns/dp/1617296279