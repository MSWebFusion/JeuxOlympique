# README

## Projet de Réservation de Billets pour les Jeux Olympiques

Ce projet consiste à mettre en place un système de réservation de billets électroniques pour les Jeux Olympiques de 2024 en France. L'objectif principal est de remplacer les tickets physiques par des e-tickets afin de garantir la sécurité et d'éviter la fraude.

### Présentation de l'Entreprise

Dans le cadre des Jeux Olympiques de 2024, l'administration de l'événement a décidé de passer des tickets physiques aux e-tickets pour des raisons de sécurité. Pour ce faire, elle a fait appel à InfoEvent, une ESN spécialisée dans ce domaine, via un processus d'appel d'offres.

### Description du Projet

Le projet consiste à développer un système de réservation de billets en ligne, avec les fonctionnalités suivantes :

1. **Page d'Accueil** : Présentation des Jeux Olympiques et des différentes épreuves.
2. **Billettrie** : Page listant les différentes offres de billets (solo, duo, familiale) avec possibilité de sélection et ajout au panier.
3. **Espace Administrateur** : Permettant de visualiser, ajouter, modifier ou créer de nouvelles offres.
4. **Authentification Utilisateur** : Les visiteurs doivent créer un compte en fournissant leur nom, prénom, adresse e-mail et mot de passe sécurisé. Une clé est générée pour chaque compte, visible uniquement par l'organisation des Jeux Olympiques.
5. **Paiement** : Les utilisateurs peuvent payer leur billet (simulation de paiement) et une nouvelle clé est générée pour sécuriser le billet acheté. Un QR Code est créé à partir de cette clé pour constituer le e-billet.
6. **Sécurité** : Un processus de sécurité doit être mis en place pour assurer l'authentification de l'utilisateur lors de la connexion.

### Installation et Utilisation

1. Cloner le projet depuis le dépôt Git.
2. Installer les dépendances nécessaires.
3. Configurer l'environnement selon les instructions fournies.
4. Lancer l'application.
5. Accéder à l'interface utilisateur pour réserver des billets.
6. Accéder à l'interface administrateur pour gérer les offres et visualiser les statistiques de ventes.

### Installation de la Base de Données

Pour avoir la base de données en local, vous aurez besoin d'un serveur SQL. Dans Visual Studio, utilisez le gestionnaire de paquets pour exécuter la commande "update-database". Cela permettra de créer ou mettre à jour la base de données locale en fonction des migrations qui ont été définies dans le projet.

### Avertissement

Ce projet est une simulation et ne doit pas être utilisé en situation réelle. Le processus de paiement est simulé et aucun paiement réel n'est effectué.