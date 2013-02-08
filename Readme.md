SqLiteQuery
===========

Français
--------

Librairie DLL pour faciliter la gestion de base SqLite sous .Net.
Pévus pour Visual Studio 2012 - x86.


Installation
------------
1) Aller sur http://system.data.sqlite.org/index.html/doc/trunk/www/downloads.wiki
2) Télécharger et installer sqlite-netFx45-setup-bundle-x86-2012-1.0.84.0.exe


Base
----
1) Ajouter en référence au projet SqLiteQuery.dll
2) Ajouter la directive suivante dans la fichier ou vous souhaiter utiliser la DLL :
	using SqLiteQuery;

	
Variables minimum
-----------------
1) Crée une instance de Query 
	Query Q = new Query("Source.db");
2) Crée une variables d'Exception
	Exception E;
	
	Notes : La variable d'exception sert a récupérer les erreurs lors de requêtes.