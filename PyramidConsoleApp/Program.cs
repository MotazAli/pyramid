using PyramidConsoleApp;

double inputNumber = UserIO.Start();
Pyramid pyramid = new Pyramid(inputNumber,'*');
pyramid.Draw();

