# TDD Introductie

## Onderwerpen

- Inleiding: Canonicalizer
- Wat is TDD en waarom hebben we het nodig?    
- Misverstanden over TDD.
- Wat is "red-green-refactor"
- De drie geboden van TDD
- TDD en unit tests
- Wanneer faalt TDD?
- Canonicalizer bouwen volgens TDD

## Inleiding
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




