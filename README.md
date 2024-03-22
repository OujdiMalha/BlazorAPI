# BlazorAPI

Cette API bas�e sur Blazor WebAssembly, une technologie qui permet de d�velopper des applications web interactives 
en utilisant C# et .NET. L'API fournit des fonctionnalit�s pour interagir avec les donn�es relatives aux Pok�mon, 
en tirant parti de l'API publique de PokeAPI (https://pokeapi.co/).

L�explication des principales composantes et fonctionnalit�s du projet :

- Mod�les (Models) :

Les mod�les repr�sentent les entit�s principales du projet, telles que les Pok�mon, les sprites, les statistiques et 
les types. Chaque mod�le est une classe C# qui contient des propri�t�s correspondant aux diff�rentes caract�ristiques 
des entit�s.


- Utilitaires (Util) :

Les utilitaires regroupent des classes qui fournissent des fonctionnalit�s r�utilisables pour l'API. Par exemple, 
la classe PokeClient encapsule la logique n�cessaire pour effectuer des requ�tes HTTP vers l'API publique de PokeAPI 
et r�cup�rer des donn�es sur les Pok�mon.



- Pages :

Les pages contiennent les composants d'interface utilisateur de l'API. Chaque page est associ�e � une URL sp�cifique et 
repr�sente une partie de l'application web. Par exemple, la page "Index" affiche une liste de Pok�mon avec des 
fonctionnalit�s telles que la possibilit� de marquer un Pok�mon comme favori, de le supprimer ou de le modifier.


- Fichiers CSS, images et HTML :

Le dossier "wwwroot" contient des fichiers statiques tels que des feuilles de style CSS, des images et des fichiers HTML. 
Ces fichiers sont utilis�s pour styliser et personnaliser l'apparence de l'application web.


- Fonctionnalit�s cl�s :

L'API permet de r�cup�rer des donn�es sur les Pok�mon � partir de l'API publique de PokeAPI en utilisant des requ�tes HTTP.

Les utilisateurs peuvent afficher une liste de Pok�mon, consulter les d�tails d'un Pok�mon sp�cifique, marquer un Pok�mon 
comme favori, le supprimer ou le modifier

Les fonctionnalit�s d'interaction avec les Pok�mon, telles que l'ajout aux favoris, la suppression et la modification, 
sont g�r�es � l'aide de m�thodes d�finies dans les classes utilitaires (PokeClient) et dans les pages.

++++++++++++++++++++  Justification de la m�thode de r�solution :

- J'ai choisi d'utiliser Blazor WebAssembly embty pour d�velopper mon API en raison de plusieurs facteurs. 
Tout d'abord, Blazor WebAssembly offre la possibilit� de d�velopper des applications web interactives en utilisant 
C# et .NET, des langages et des frameworks. Cela m'a permis de capitaliser sur mes connaissance pour d�velopper mon API.

- De plus,Blazor WebAssembly permet le partage de code entre le c�t� serveur et le c�t� client, ce qui signifie que je peux 
r�utiliser une grande partie de ma logique m�tier dans l'ensemble de mon application. Cela contribue � une meilleure 
maintenabilit� et �vite la duplication de code.

- Enfin,le d�ploiement d'une application Blazor WebAssembly est simple et peut se faire dans n'importe quel navigateur 
web moderne, ce qui permet une large distribution de mon API sans avoir besoin d'installer des d�pendances suppl�mentaires 
du c�t� client.



++++++++++++++++++++++  Justification des choix conceptuels et m�thodologiques :

- Pour concevoir mon API, j'ai opt� pour une approche bas�e sur des classes pour repr�senter les entit�s telles que 
les Pok�mon, les statistiques et les types. Cette approche permet une mod�lisation claire et pr�cise des donn�es, 
ce qui facilite la compr�hension et la maintenance du code.

- J'ai �galement organis� les fonctionnalit�s de mon API en packages logiques, tels que "Models" pour les entit�s de donn�es,
"Util" pour les utilitaires et les services, et "Pages" pour les composants d'interface utilisateur. Cette organisation
en couches favorise la s�paration des pr�occupations et rend le code plus facile � naviguer et � g�rer.

- En utilisant des services comme le PokeClient pour encapsuler la logique r�utilisable, j'ai pu rendre mon API plus 
modulaire et extensible. Cela me permet d'ajouter de nouvelles fonctionnalit�s ou de modifier le comportement 
existant avec un impact minimal sur le reste de l'application.