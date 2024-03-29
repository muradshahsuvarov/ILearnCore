﻿var connection = new signalR.HubConnectionBuilder()
    .withUrl('/User/OpenChat')
    .build();

connection.on('receiveMessage', addMessageToChat); // Sends messages in every frame to addMessageToChat
connection.on('checkNotifs', checkNotifications); // Checks notifs


connection.start()
    .catch(error => {
        console.error(error.message);
    });

function sendMessageToHub(message) {
    connection.invoke('SendMessage', message) // SendMessage is a C# HUB Method in ChatHub.cs
}

function sendNotifToHub() {
    connection.invoke('CheckNotification') // SendMessage is a C# HUB Method in ChatHub.cs
}