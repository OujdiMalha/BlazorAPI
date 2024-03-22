# BlazorAPI

Cette API basée sur Blazor WebAssembly, une technologie qui permet de développer des applications web interactives 
en utilisant C# et .NET. L'API fournit des fonctionnalités pour interagir avec les données relatives aux Pokémon, 
en tirant parti de l'API publique de PokeAPI (https://pokeapi.co/).

L’explication des principales composantes et fonctionnalités du projet :

- Modèles (Models) :

Les modèles représentent les entités principales du projet, telles que les Pokémon, les sprites, les statistiques et 
les types. Chaque modèle est une classe C# qui contient des propriétés correspondant aux différentes caractéristiques 
des entités.


- Utilitaires (Util) :

Les utilitaires regroupent des classes qui fournissent des fonctionnalités réutilisables pour l'API. Par exemple, 
la classe PokeClient encapsule la logique nécessaire pour effectuer des requêtes HTTP vers l'API publique de PokeAPI 
et récupérer des données sur les Pokémon.



- Pages :

Les pages contiennent les composants d'interface utilisateur de l'API. Chaque page est associée à une URL spécifique et 
représente une partie de l'application web. Par exemple, la page "Index" affiche une liste de Pokémon avec des 
fonctionnalités telles que la possibilité de marquer un Pokémon comme favori, de le supprimer ou de le modifier.


- Fichiers CSS, images et HTML :

Le dossier "wwwroot" contient des fichiers statiques tels que des feuilles de style CSS, des images et des fichiers HTML. 
Ces fichiers sont utilisés pour styliser et personnaliser l'apparence de l'application web.


- Fonctionnalités clés :

L'API permet de récupérer des données sur les Pokémon à partir de l'API publique de PokeAPI en utilisant des requêtes HTTP.

Les utilisateurs peuvent afficher une liste de Pokémon, consulter les détails d'un Pokémon spécifique, marquer un Pokémon 
comme favori, le supprimer ou le modifier

Les fonctionnalités d'interaction avec les Pokémon, telles que l'ajout aux favoris, la suppression et la modification, 
sont gérées à l'aide de méthodes définies dans les classes utilitaires (PokeClient) et dans les pages.

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