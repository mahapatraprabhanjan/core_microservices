# core_microservices
Micro services using .Net core stack of technologies.

This project is developed using -

.Net Core
RabbitMq - Running in a docker container
MongoDB as the database

Project Structure
Micro.Common - A common project that has the interfaces and classes definitions for Events, Commands, RabbitMq helper classes.

In order to up the RabbitMq container you need to run the following command -
Since we are using the RabbitMq Management we will use the following command -

<b>docker run -d -p 5672:5672 -p 15672:15672 --name rabbitmq library/rabbitmq:3.7.8-managment</b>

In order to up the MongoDB container you need to run the following command -

<b>docker run -d -p 27017:27017 mongo</b>

<b>NOTE:</b> If mongo image is not available in your local it will pull the latest MongoDB image and run the container. The -p 27017:27017 exposes MongoDB on 27017 which is the default port for MongoDB. 
