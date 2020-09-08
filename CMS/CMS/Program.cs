using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace CMS
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fd = new FileStream("input.txt",FileMode.Open);
            FileStream fw = new FileStream("out.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fw);
            StreamReader sr = new StreamReader(fd);
            bool invoice = false;
            int i=0;
            String l1 = null;
            String name=null;
            String Adress=null;
            String City=null;
            String Province=null;
            String postal=null;
            string number=null;
            string total = null;
            int s = 1;

            sw.WriteLine(s);
            String l = sr.ReadLine();
           
            while (l != null)
            {
                
                
                
                if(l.Equals("INVOICE"))
                {
                    invoice = true;
                    i = 0;
                }
                if (l .Equals("Invoice Number:"))
                {
                    invoice = false;
                   

                }
                if (l.Equals("Total"))
                {
                    l = sr.ReadLine();
                    l = sr.ReadLine();
                    total = l;
                
                    s++;
                    sw.WriteLine(total + "\n");
                    sw.WriteLine(s);

                }
                 
                    if (invoice)
                    {

                        Console.WriteLine(l);

                        Console.WriteLine(i);

                        if(i==1)
                        {
                            name = l;
                         sw.WriteLine(name);
                       
                        }
                        else if(i==2)
                        {
                            Adress = l;
                           

                        }
                        else if (i == 3  )
                        {
                            Adress = Adress+ " " + l;
                           


                        }
                        else if (i == 4)
                        {
                           
                           if (l == "Sindh" || l == "Punjab" || l == "Balochistan" || l == "KPK"||l=="Islamabad Capital Territory")
                           {
                               City = l1;
                               sw.WriteLine(City);
                               Province = l;
                               sw.WriteLine(Province);
                               i++;
                               i++;

                           }
                           else
                           {
                               Adress = Adress + " " + l;
                               sw.WriteLine(Adress);
                           }
                          
                           


                        }
                        else if (i == 5)
                        {
                            if (l == "Sindh" || l == "Punjab" || l == "Balochistan" || l == "KPK" || l == "Islamabad Capital Territory")
                            {
                                 City=l1;
                                sw.WriteLine(City);
                                 Province = l;
                                sw.WriteLine(Province);
                                i++;
                               
                            }
                            else
                            {
                                City = l;
                                sw.WriteLine(City);
                            }
                            
                           
                           
                        }
                          else if (i == 6)
                        {
                            Province = l;
                            sw.WriteLine(Province);
                           
                           
                        }
                        else if (i == 7)
                        {
                           postal = l;
                           sw.WriteLine(postal);
                         

                        }
                        else if (i == 8)
                        {
                            number = l;
                            sw.WriteLine(number);
                           
                           

                        }
                        i++;
                       
                    }
                    l1 = l;
                    l = sr.ReadLine();
                

            }
            sw.Close();
            sr.Close();
            fw.Close();
            fd.Close();


        }
    }
}
