# DDD In practice

DDD is only good for projects that have a lot of complex business rules - where business logic complexity is the main hurdle.

DDD -  Focus on essential parts. Simplify the problem.

+ ubiquitous language (identify differences, discuss and get in sync)
+ bounded contexts
+ core domain (we always focus most of our efforts on the core domain)

+ talk with the domain experts. strive to become a domain expert yourself

#### Onion architecture

https://jeffreypalermo.com/tag/onion-architecture/

Upper layers depend on the lower ones. Core part of the structure does not depend on anything but itself




@ gettting a bit side tracked with vertical slice architecture - will look at that and then maybe come back to this..


## DDD The Good Parts

https://www.youtube.com/watch?v=L3SvIKdLt88

The Majestic Monolith Myth: Forget microservices etc, just build a good monolith :)

DDD is all about the Bounded Context. Structural Patterns (Value Objects, Entities and so on) are the least important but get the most attention. (see DDD 10 years later talk by E.Evans)

SQl Server has no concept of value objects. Only use if the datastore can support them.


If there is a lot of friction in the ubiquitous language perhaps they should be different systems.

CQRS is great, apparantly.

TODO: explore "service boundaries" on youtube

TODO: "Building Microservices" by Sam Newman, is essentially DDD the good parts


## Going Crazy with CQRS

Bounded Context containing ag.roots of Entity && Value Object

Separate Read/Write Models. 

Leter in DDD, Domain Events were added as an afterthought, but this is a core piece of CQRS

Event Oriented. 

CQRS Summary: 
+ UI -> WriteModel (receive command, validations)
+ WriteModel emit Events (to Read Model)
+ ReadModel -> UI

Read and write joined by events (and ui)

slide here xxxxxxxxxxxxxxx

@25:12 - not a great talk :(