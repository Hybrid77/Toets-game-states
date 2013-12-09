﻿//met using kan je een microsoft xna codebibliotheek toevoegen gebruiken in je class.
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PyramidPanic
{
   public class Menu
    {
       //Fields
       //maak een variable (reference) van het typen Image
       private Image start;
       private Image load;
       private Image scores;
       private Image help;
       private Image quit;

       //maak een variable (reference) van het typen PyramidPanic
       private PyramidPanic game;


       //Constructor
       public Menu(PyramidPanic game){
           this.game = game;
           this.Initialize();
       }

       public void Initialize() {
           this.LoadContent();
       
       }


       public void LoadContent() {

           this.start = new Image(this.game, @"StartScene\Button_start", new Vector2 (20f, 433f));
           this.load = new Image(this.game, @"StartScene\Button_load", new Vector2(147f, 433f));
           this.help = new Image(this.game, @"StartScene\Button_help", new Vector2(274f, 433f));
           this.scores = new Image(this.game, @"StartScene\Button_scores", new Vector2(401f, 433f));
           this.quit = new Image(this.game, @"StartScene\Button_quit", new Vector2(530f, 433f));

       }

       //update
       public void Update(GameTime gameTime) { 
       
       }



       //Draw
       public void Draw(GameTime gameTime)
       {
           this.start.Draw(gameTime);
           this.load.Draw(gameTime);
           this.help.Draw(gameTime);
           this.scores.Draw(gameTime);
           this.quit.Draw(gameTime);
       }



    }
}
