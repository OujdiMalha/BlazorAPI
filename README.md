# BlazorAPI

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