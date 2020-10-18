using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMancalaV1
{
    class Board
    {
        public int playerPoints; //player points are banked here
        public int pcPoints; // pc points are banked here
        public int[,] itemsInSpot = new int[2, 6]; //the points or items are banked in each spot in this array
        public Boolean turn; //true means this is the player1's turn, false means this is player2's turn

        public Board(int[,] itemsInSpot, int playerPoints, int pcPoints, Boolean turn)
        {
            this.itemsInSpot = itemsInSpot;
            this.playerPoints = playerPoints;
            this.pcPoints = pcPoints;
            this.turn = turn;

        }

        public void restartBoard() //resets the board
        {
            for (int i = 0; i < 6; i++)
            {
                this.itemsInSpot[0, i] = 4;
                this.itemsInSpot[1, i] = 4;
                this.pcPoints = 0;
                this.playerPoints = 0;
            }
        }


        public Boolean IsFinal() //Checks if the game is finished - if there are no more items in every place other than the player's or computer's last store
        {
            return (this.pcPoints + this.playerPoints == 48);

        }

        

        public void Movement(int xLoc, int yLoc) //movement of the items is made in this program
        {
            
            int itemSpot = this.itemsInSpot[yLoc, xLoc];
            itemsInSpot[yLoc, xLoc] = 0;
            while (itemSpot > 0)
            {
                if (itemSpot == 1 && this.turn == false&& xLoc==5&&yLoc==0)
                {
                    this.pcPoints++;
                    this.turn = true;
                    itemSpot--;
                }
                else
                {
                    if (itemSpot == 1 && this.turn == true && xLoc == 0 && yLoc == 1)
                    {
                        this.playerPoints++;
                        this.turn = false;
                        itemSpot--;
                    }
                    else
                    {
                        if (itemSpot == 1 && this.turn == false && yLoc == 0 && xLoc != 5 && this.itemsInSpot[1, xLoc + 1] > 0 && this.itemsInSpot[0, xLoc + 1] == 0) //rule in mancala if the bin opposite to the player's bin is not empty and the player's is empty and it's the last item so all the two bins go the player's points
                        {
                            xLoc++;
                            this.pcPoints = this.pcPoints + this.itemsInSpot[1, xLoc] + 1;
                            itemSpot--;
                            itemsInSpot[1, xLoc] = 0;
                        }
                        else
                        {
                            if (itemSpot == 1 && this.turn == true && yLoc == 1 && xLoc != 0 && this.itemsInSpot[1, xLoc - 1] == 0 && this.itemsInSpot[0, xLoc - 1] > 0) //rule in mancala if the bin opposite to the computer's bin is not empty and the computer's is empty and it's the last item so all the two bins go the computer's points
                            {
                                xLoc--;
                                this.playerPoints = this.playerPoints + this.itemsInSpot[0, xLoc] + 1;
                                this.itemsInSpot[0, xLoc] = 0;
                                itemSpot--;
                            }
                            else
                            {
                                if (yLoc == 1 && itemSpot > 0 && xLoc == 0)
                                {
                                    yLoc = 0;
                                    this.playerPoints++;
                                    itemSpot--;
                                    if (itemSpot > 0)
                                    {
                                        this.itemsInSpot[0, 0]++;
                                        itemSpot--;
                                    }
                                }
                                else
                                {
                                    if (yLoc == 1 && itemSpot > 0 && xLoc > 0)
                                    {
                                        xLoc--;
                                        itemSpot--;
                                        this.itemsInSpot[yLoc, xLoc]++;

                                    }
                                    else
                                    {
                                        if (yLoc == 0 && itemSpot > 0 && xLoc == 5)
                                        {
                                            yLoc = 1;
                                            itemSpot--;
                                            this.pcPoints++;
                                            if (itemSpot > 0)
                                            {
                                                this.itemsInSpot[1, 5]++;
                                                itemSpot--;
                                            }
                                        }
                                        else
                                        {
                                            if (yLoc == 0 && itemSpot > 0 && xLoc < 5)
                                            {
                                                xLoc++;
                                                itemSpot--;
                                                this.itemsInSpot[yLoc, xLoc]++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
                
            }
            if (this.turn == true)
            {
                this.turn = false;
            }
            else
            {
                this.turn = true;
            }
        }

        
    }
}

