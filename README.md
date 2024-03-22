# BlazorAPI

++++++++++++++++++++  Justification de la méthode de résolution :

- J'ai choisi d'utiliser Blazor WebAssembly embty pour développer mon API en raison de plusieurs facteurs. 
Tout d'abord, Blazor WebAssembly offre la possibilité de développer des applications web interactives en utilisant 
C# et .NET, des langages et des frameworks. Cela m'a permis de capitaliser sur mes connaissance pour développer mon API.

- De plus,Blazor WebAssembly permet le partage de code entre le côté serveur et le côté client, ce qui signifie que je peux 
réutiliser une grande partie de ma logique métier dans l'ensemble de mon application. Cela contribue à une meilleure 
maintenabilité et évite la duplication de code.

- Enfin,le déploiement d'une application Blazor WebAssembly est simple et peut se faire dans n'importe quel navigateur 
web moderne, ce qui permet une large distribution de mon API sans avoir besoin d'installer des dépendances supplémentaires 
du côté client.



++++++++++++++++++++++  Justification des choix conceptuels et méthodologiques :

- Pour concevoir mon API, j'ai opté pour une approche basée sur des classes pour représenter les entités telles que 
les Pokémon, les statistiques et les types. Cette approche permet une modélisation claire et précise des données, 
ce qui facilite la compréhension et la maintenance du code.

- J'ai également organisé les fonctionnalités de mon API en packages logiques, tels que "Models" pour les entités de données,
"Util" pour les utilitaires et les services, et "Pages" pour les composants d'interface utilisateur. Cette organisation
en couches favorise la séparation des préoccupations et rend le code plus facile à naviguer et à gérer.

- En utilisant des services comme le PokeClient pour encapsuler la logique réutilisable, j'ai pu rendre mon API plus 
modulaire et extensible. Cela me permet d'ajouter de nouvelles fonctionnalités ou de modifier le comportement 
existant avec un impact minimal sur le reste de l'application.