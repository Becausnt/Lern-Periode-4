using Discord;
using Discord.Commands;
using Discord.Interactions;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameBot;

namespace GameBot.modules
{
    
    public class commands : ModuleBase<SocketCommandContext>
    {
        bool gameRunning = false;
        public char[] playingField = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char playerTurn = 'X';


        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong");
        }

        [Command("button")]
        public async Task Button()
        {
            var builder = new ComponentBuilder()
                .WithButton("hi", "test-btn");

            await ReplyAsync("Here is a button!", components: builder.Build());
        }

        [Command("delete")]
        public async Task DeleteChat(int amount = 99)
        {
            // Fetch the messages and flatten the result into an IEnumerable
            var messages = await Context.Channel.GetMessagesAsync(amount + 1).FlattenAsync();

            // Delete the messages
            await ((ITextChannel)Context.Channel).DeleteMessagesAsync(messages);
        }

        [Command("tictactoe")]
        public async Task TicTacToe()
        {
            var components = new ComponentBuilder();
            var select = new SelectMenuBuilder()
            {
                CustomId = "menu1",
                Placeholder = "Select something"
            };
            // Options are added to the select menu. The option values can be generated on execution of the command. You can then use the value in the Handler for the select menu
            // to determine what to do next. An example would be including the ID of the user who made the selection in the value.
            select.AddOption("1", "1");
            select.AddOption("2", "2");
            select.AddOption("3", "3");
            select.AddOption("4", "4");
            select.AddOption("5", "5");
            select.AddOption("6", "6");
            select.AddOption("7", "7");
            select.AddOption("8", "8");
            select.AddOption("9", "9");

            components.WithSelectMenu(select);

            gameRunning = true;
            var botMessage = await ReplyAsync($" {playingField[0]}|{playingField[1]}|{playingField[2]}\n{playingField[3]}|{playingField[4]}|{playingField[5]}\n{playingField[6]}|{playingField[7]}|{playingField[8]}", components: components.Build());
        }

        [Command("remindme")]
        public async Task Remindme(int secondsUntilReminder, string reminderNote = "")
        {
            if (secondsUntilReminder > 0)
            {
                ReplyAsync($"Reminder set for {Context.User.GlobalName} in {secondsUntilReminder} second/s.");

                int millisecondsUntilReminder = secondsUntilReminder * 1000; // convert seconds to milliseconds because Task.Delay takes milliseconds as argument

                await Task.Delay(millisecondsUntilReminder);

                string reminderMessage = $"{Context.User.Mention} don't Forget: {reminderNote}";

                ReplyAsync(reminderMessage);
            }
        }
        [Command("coinflip")]
        public async Task Coinflip()
        {
            Random random = new Random();
            string coinResult;

            coinResult = random.Next(0, 2) == 1 ? "Tails" : "Heads";

            string replyMessage = $"It was {coinResult}";
            ReplyAsync(replyMessage);
        }
        public async Task MenuHandler(SocketMessageComponent component)
        {

            var components = new ComponentBuilder();
            var select = new SelectMenuBuilder()
            {
                CustomId = "menu1",
                Placeholder = "Select something"
            };
            
            select.AddOption("1", "1");
            select.AddOption("2", "2");
            select.AddOption("3", "3");
            select.AddOption("4", "4");
            select.AddOption("5", "5");
            select.AddOption("6", "6");
            select.AddOption("7", "7");
            select.AddOption("8", "8");
            select.AddOption("9", "9");

            components.WithSelectMenu(select);


            switch (component.Data.CustomId)
            {
                case "menu1":

                    int selectedField = Convert.ToInt32(component.Data.Values.First()) -1;
                    if (!(playingField[selectedField] == 'X' || playingField[selectedField] == 'O'))
                    {
                        playingField[selectedField] = playerTurn;
                    }   
                    await component.RespondAsync($" {playingField[0]}|{playingField[1]}|{playingField[2]}\n{playingField[3]}|{playingField[4]}|{playingField[5]}\n{playingField[6]}|{playingField[7]}|{playingField[8]}", components: components.Build());

                    //var chnl = _client.GetChannel(1209402857380380683) as IMessageChannel;
                    //await chnl.SendMessageAsync($"Player {playerTurn} has won.");
                    //await component.RespondAsync($"You selected {component.Data.Values.First()}"); // .First() ist das momentan ausgewählte


                    // check rows
                    for (int i = 0; i < 3; i++ )
                    {
                        if (playingField[i*3 + 1] == playerTurn && playingField[i*3 + 2] == playerTurn && playingField[i*3 + 3] == playerTurn)
                        {
                           
                        }
                    }

                    playerTurn = playerTurn == 'X' ? 'O' : 'X'; // look up 'ternary operator'

                    break;
            }
        }        
    }
}
