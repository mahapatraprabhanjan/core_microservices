# core_microservices
Micro services using .Net core stack of technologies.

This project is developed using -

.Net Core
RabbitMq - Running in a docker container

Project Structure
Micro.Common - A common project that has the interfaces and classes definitions for Events, Commands, RabbitMq helper classes.

In order to up the RabbitMq container you need to run the following command -
Since we are using the RabbitMq Management we will use the following command -

<b>docker run -d -p 5672:5672 -p 15672:15672 --name rabbitmq library/rabbitmq:3.7.8-managment</b>
