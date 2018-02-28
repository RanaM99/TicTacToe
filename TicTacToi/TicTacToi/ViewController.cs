using CoreGraphics;
using System;

using UIKit;

namespace TicTacToi
{
    public partial class ViewController : UIViewController
    {
        private int turn = 0;
        private int player1 = 0;
        private int click1 = 0;
        private int player2 = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            viewX.Layer.ShadowColor = UIColor.LightGray.CGColor;
            viewX.Layer.BorderColor = UIColor.LightGray.CGColor;
            viewX.Layer.BorderWidth = 1;
            viewX.Layer.CornerRadius = 5;
            viewX.Layer.ShadowRadius = 10;
            viewX.Layer.ShadowOpacity = 3;

            viewO.Layer.ShadowColor = UIColor.LightGray.CGColor;
            viewO.Layer.BorderColor = UIColor.LightGray.CGColor;
            viewO.Layer.BorderWidth = 1;
            viewO.Layer.CornerRadius = 5;
            viewO.Layer.ShadowRadius = 10;
            viewX.Layer.ShadowOpacity = 3;


            button1.SetTitle("", UIControlState.Normal);
            button2.SetTitle("", UIControlState.Normal);
            button3.SetTitle("", UIControlState.Normal);
            button4.SetTitle("", UIControlState.Normal);
            button5.SetTitle("", UIControlState.Normal);
            button6.SetTitle("", UIControlState.Normal);
            button7.SetTitle("", UIControlState.Normal);
            button8.SetTitle("", UIControlState.Normal);
            button9.SetTitle("", UIControlState.Normal);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                viewX.BackgroundColor = UIColor.Cyan;
                viewO.BackgroundColor = UIColor.White;
            }
            else
            {
                viewO.BackgroundColor = UIColor.Cyan;
                viewX.BackgroundColor = UIColor.White;
            }
        }

        partial void Button1_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button1.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button1.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button1.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button1.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }

            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button2_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button2.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button2.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button2.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button2.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button3_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button3.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button3.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button3.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button3.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button4_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button4.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button4.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button4.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button4.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button5_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button5.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button5.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button5.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button5.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button6_TouchUpInside(UIButton sender)
        {
           switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button6.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button6.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button6.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button6.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button7_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button7.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button7.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button7.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button7.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button8_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button8.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button8.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button8.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button8.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        partial void Button9_TouchUpInside(UIButton sender)
        {
            switch (click1)
            {
                case 0:
                    if (turn % 2 != 0)
                    {
                        button9.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button9.SetTitle("X", UIControlState.Normal);
                    }
                    break;
                default:
                    if (turn % 2 != 0)
                    {
                        button9.SetTitle("O", UIControlState.Normal);
                    }
                    else
                    {
                        button9.SetTitle("X", UIControlState.Normal);
                    }
                    break;
            }
            turn++;
            click1++;
            display();
            checkit();
        }

        public void checkit()
        {
            //For Row
            if (!button1.Title(UIControlState.Normal).Equals("") || !button2.Title(UIControlState.Normal).Equals("") || !button3.Title(UIControlState.Normal).Equals(""))
            {
                if (button1.Title(UIControlState.Normal).Equals(button2.Title(UIControlState.Normal)) && button1.Title(UIControlState.Normal).Equals(button3.Title(UIControlState.Normal)))
                {
                    if (button1.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            if (!button4.Title(UIControlState.Normal).Equals("") || !button5.Title(UIControlState.Normal).Equals("") || !button6.Title(UIControlState.Normal).Equals(""))
            {
                if (button4.Title(UIControlState.Normal).Equals(button5.Title(UIControlState.Normal)) && button4.Title(UIControlState.Normal).Equals(button6.Title(UIControlState.Normal)))
                {
                    if (button4.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }

                }
            }

            if (!button7.Title(UIControlState.Normal).Equals("") || !button8.Title(UIControlState.Normal).Equals("") || !button9.Title(UIControlState.Normal).Equals(""))
            {
                if (button7.Title(UIControlState.Normal).Equals(button8.Title(UIControlState.Normal)) && button7.Title(UIControlState.Normal).Equals(button9.Title(UIControlState.Normal)))
                {
                    if (button7.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            //For column
            if (!button1.Title(UIControlState.Normal).Equals("") || !button4.Title(UIControlState.Normal).Equals("") || !button7.Title(UIControlState.Normal).Equals(""))
            {
                if (button1.Title(UIControlState.Normal).Equals(button4.Title(UIControlState.Normal)) && button1.Title(UIControlState.Normal).Equals(button7.Title(UIControlState.Normal)))
                {
                   if (button1.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            if (!button2.Title(UIControlState.Normal).Equals("") || !button5.Title(UIControlState.Normal).Equals("") || !button8.Title(UIControlState.Normal).Equals(""))
            {
                if (button2.Title(UIControlState.Normal).Equals(button5.Title(UIControlState.Normal)) && button2.Title(UIControlState.Normal).Equals(button8.Title(UIControlState.Normal)))
                {
                    if (button2.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            if (!button3.Title(UIControlState.Normal).Equals("") || !button6.Title(UIControlState.Normal).Equals("") || !button9.Title(UIControlState.Normal).Equals(""))
            {
                if (button3.Title(UIControlState.Normal).Equals(button6.Title(UIControlState.Normal)) && button3.Title(UIControlState.Normal).Equals(button9.Title(UIControlState.Normal)))
                {
                   if (button3.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            //For Diagonal
            if (!button1.Title(UIControlState.Normal).Equals("") || !button5.Title(UIControlState.Normal).Equals("") || !button9.Title(UIControlState.Normal).Equals(""))
            {
                if (button1.Title(UIControlState.Normal).Equals(button5.Title(UIControlState.Normal)) && button1.Title(UIControlState.Normal).Equals(button9.Title(UIControlState.Normal)))
                {
                    if (button1.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }

            if (!button3.Title(UIControlState.Normal).Equals("") || !button5.Title(UIControlState.Normal).Equals("") || !button7.Title(UIControlState.Normal).Equals(""))
            {
                if (button3.Title(UIControlState.Normal).Equals(button5.Title(UIControlState.Normal)) && button3.Title(UIControlState.Normal).Equals(button7.Title(UIControlState.Normal)))
                {
                    if (button3.Title(UIControlState.Normal).Equals("X"))
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "X";
                        player1++;
                        labelPlayer1Score.Text = player1.ToString();
                    }
                    else
                    {
                        viewWinner.Hidden = false;
                        labelWinner.Text = "O";
                        player2++;
                        labelPlayer2Score.Text = player2.ToString();
                    }
                }
            }
        }

        partial void ButtonRestart_TouchUpInside(UIButton sender)
        {
            button1.SetTitle("", UIControlState.Normal);
            string btn1 = button1.Title(UIControlState.Normal);
            button2.SetTitle("", UIControlState.Normal);
            string btn2 = button2.Title(UIControlState.Normal);
            button3.SetTitle("", UIControlState.Normal);
            string btn3 = button3.Title(UIControlState.Normal);
            button4.SetTitle("", UIControlState.Normal);
            string btn4 = button4.Title(UIControlState.Normal);
            button5.SetTitle("", UIControlState.Normal);
            string btn5 = button5.Title(UIControlState.Normal);
            button6.SetTitle("", UIControlState.Normal);
            string btn6 = button6.Title(UIControlState.Normal);
            button7.SetTitle("", UIControlState.Normal);
            string btn7 = button7.Title(UIControlState.Normal);
            button8.SetTitle("", UIControlState.Normal);
            string btn8 = button8.Title(UIControlState.Normal);
            button9.SetTitle("", UIControlState.Normal);
            string btn9 = button9.Title(UIControlState.Normal);
            turn = 0;
            click1 = 0;
            viewWinner.Hidden = true;
        }
    }
}
