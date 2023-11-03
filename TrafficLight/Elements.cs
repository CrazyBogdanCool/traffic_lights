﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLight
{
    internal class TrafficLight : Color
    {
        public void TurnOn()
        {
            Red(10000);
            RedYellow(2000, 2);
            Grean(10000, 0);
            Grean(1000, 4);
            Yellow(2000);
            TurnOn();
        }
    }
    class Color
    {
        public void NoColor(int time)
        {
            Console.WriteLine(@" 
                  &&&&&&&&&&&&&&&                 
               &&#################&&              
   &&//////////&#####&&&&#&&&&#####&//////////&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&%/&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&/.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&&&&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &&#################&& ");
            Thread.Sleep(time);
            Console.Clear();
        }
        public void Grean(int time, int numOfOperations)
        {
            Console.WriteLine(@" 
                  &&&&&&&&&&&&&&&                 
               &&#################&&              
   &&//////////&#####&&&&#&&&&#####&//////////&&  
   &&//////////&###&&*********&&###&//////////&%  
    &&/////////&###&&*********&&###&////////(&&   
      &&&//////&###&&*********&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&%/&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&/.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&&&&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &&#################&& ");
            Thread.Sleep(time);
            Console.Clear();
            if (numOfOperations <= 0)
            {
                return;
            }
            NoColor(time);
            Grean(time, numOfOperations - 1);
        }
        public void Yellow(int time)
        {
            Console.WriteLine(@" 
                  &&&&&&&&&&&&&&&                 
               &&#################&&              
   &&//////////&#####&&&&#&&&&#####&//////////&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&%/&&&&#####&((((((((((&&  
   &&//////////&###&&*********&&###&//////////&%  
    &&/////////&###&/*********&&###&////////(&&   
      &&&//////&###&&*********&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&&&&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &&#################&& ");
            Thread.Sleep(time);
            Console.Clear();
        }
        public void Red(int time)
        {
            Console.WriteLine(@" 
                  &&&&&&&&&&&&&&&                 
               &&#################&&              
   &&//////////&#####&&&&#&&&&#####&//////////&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&%/&&&&#####&((((((((((&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&/.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&&&&&&&#####&((((((((((&&  
   &&//////////&###&&*********&&###&//////////&%  
    &&/////////&###&&*********&&###&////////(&&   
      &&&//////&###&&*********&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &&#################&& ");
            Thread.Sleep(time);
            Console.Clear();
        }
        public void RedYellow(int time, int numOfOperations)
        {
            if (numOfOperations <= 0)
            {
                return;
            }
            Console.WriteLine(@" 
                  &&&&&&&&&&&&&&&                 
               &&#################&&              
   &&//////////&#####&&&&#&&&&#####&//////////&&  
   &&//////////&###&&.........&&###&//////////&%  
    &&/////////&###&&.........&&###&////////(&&   
      &&&//////&###&&.........&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&%/&&&&#####&((((((((((&&  
   &&//////////&###&&*********&&###&//////////&%  
    &&/////////&###&/*********&&###&////////(&&   
      &&&//////&###&&*********&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &###################&              
   &&((((((((((&#####&&&&&&&&&#####&((((((((((&&  
   &&//////////&###&&*********&&###&//////////&%  
    &&/////////&###&&*********&&###&////////(&&   
      &&&//////&###&&*********&&###&//////&&&     
         &&&&&&&#####&&&&&&&&&#####&&&&&&&        
               &&#################&& ");
            Thread.Sleep(time / 2);
            Console.Clear();
            NoColor(time / 2);
            RedYellow(time, numOfOperations - 1);
        }
    }
}