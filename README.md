# Gestion-CMD-LIV

<h2> I. Introduction </h2>

* Notre objectif était de réaliser cette application. Son écoute et ses conseils nous ont permis de bien comprendre la technologie ADO.NET qui est un ensemble de composants logiciels que les programmeurs peuvent utiliser pour accéder à des services de données à partir d' une base de données.

* Notre objectif est de réaliser l’analyse à l’aide de schéma UML (notamment Diagramme de cas d'utilisation, Diagramme de séquence basique et diagramme de classe).


<h2> II. Fonctionnalité de l’application  </h2>

* Notre application se compose de deux parties :
La Première Partie C'est La Gestion Des Commandes : 
Lorsqu'un client passe une commande, celle-ci sera réalisée par un agent dit “Commercial”. L’accès de ce dernier est limité exclusivement au profil du compte d'utilisateur et ne peut visionner que cette partie, sans avoir la possibilité d'ajouter de nouveaux produits. L’application limite son rôle à l’activité de vente des articles qui se trouvent dans  notre stock.
Le détail de chaque commande se trouve dans la table "DETAIL_COMMANDE", et à chaque fois qu’on valide une commande, la quantité en stocks sera diminuée automatiquement dans la table "PRODUIT".

* La Deuxième Partie C'est La Gestion Des Livraisons :
C’est la réception de la marchandise qui est livrée par le Fournisseur et qui sera traitée par un agent dit “  Vendeur ”. L’accès de ce dernier est limité exclusivement au profil du compte d'utilisateur et ne peut visionner que cette partie. Cependant, il a la possibilité d'ajouter de nouveaux produits livrés par le fournisseur, et le détail de chaque livraison se trouve dans la table "DETAIL_LIVRAISON", et à chaque fois qu’on valide une livraison, la quantité de stock sera augmentée automatiquement de la table "PRODUIT ".
Les deux parties en question sont chapeautées par un troisième profil du compte d'utilisateur appelé “Administrateur”. Il a accès à l’ensemble des données de l’application (partie Gestion de Commande et Gestion Livraison).

<h2> III. Les outils du projet  </h2>

* Développement de la partie Back-End : 
Le développement back-end programme la partie cachée d’une solution, C# peuvent être déployées sur de multiples plates-formes comme Windows, UNIX, Linux, MacOS, et bien d’autres, peuvent tirer aussi une partie technique de codage orienté objet pour améliorer les tâches de codage grâce aux classes.

* Développement de la partie Front-End : 
Le terme front-end désigne les éléments d'un site ou d'une application que les utilisateurs voient à l'écran et avec lesquels ils vont interagir. À titre d'exemple, tout ce que les internautes vont voir sur un site internet, c'est une combinaison de HTML, CSS et JavaScript. Ce sont ces langages de programmation front-end qui seront interprétés par le navigateur.
Le HTML est le langage fondamental qui permet de créer et d'organiser le contenu web. C'est ce langage qui va permettre au contenu web d'être affiché sur un navigateur.
Le CSS est un langage front-end qui vient compléter les fonctions du HTML. Il a pour rôle de définir le style du contenu du site internet : mise en page, couleurs, polices... 
front-end va également utiliser JavaScript. Il s'agit d'un langage de programmation qui permet de rendre les pages web interactives, comme des menus déroulants et les formulaires de contact.

* Intégration des deux parties en RESTFUL API : 
Une API REST (également appelée API RESTful) est une interface de programmation d'application (API ou API web) qui respecte les contraintes du style d'architecture REST et permet d'interagir avec les services web RESTful. L'architecture REST (Representational State Transfer) a été créée par l'informaticien Roy Fielding.
Une API est un ensemble de définitions et de protocoles qui facilite la création et l'intégration de logiciels d'applications.
REST est un ensemble de contraintes architecturales. Il ne s'agit ni d'un protocole, ni d'une norme. Les développeurs d'API peuvent mettre en œuvre REST de nombreuses manières.

* Environnement de la base de données
Notre choix pour Microsoft SQL Server  est justifié par sa compatibilité avec ADO.NET,
En effet, Microsoft SQL Server  est un système de gestion de base de données (SGBD) en langage SQL.il est aussi un logiciel système servant à stocker, à manipuler ou gérer, et à partager des informations dans une base de données.


<h2> IV. Modélisation UML </h2>

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;1.Diagramme de classe : </h3>
<br>

![Classe UML](https://user-images.githubusercontent.com/83125801/184262770-d9fa0d39-46eb-4377-9e66-f1a0b7bd075b.jpg)

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2.Diagramme de cas d'utilisation : </h3>
<br>

![Classe UML - Diagramme de cas d'utilisation       02](https://user-images.githubusercontent.com/83125801/184266064-184e1add-ac1d-47da-9813-556ac5fde47a.jpeg)

<h3>    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;3.Diagramme de séquence basique : </h3>
<br>

![Diagramme de séquence basique (2)](https://user-images.githubusercontent.com/83125801/184266177-d1f5738f-bed5-4e17-9c30-182d3d53655a.jpeg)


<h2> V. CONCLUSION  </h2>
* A travers le développement de cette application, j'ai pu comprendre et expérimenter les différentes étapes de la conception d’un logiciel, en commençant par l’analyse avec la partie UML. 

* De plus la programmation dans le cadre de ce projet m'a permis d’approfondir mes connaissances sur les differents outlis utiliser.
