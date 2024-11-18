using NHL_Players;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;

namespace NHL_Players
{
    public class Parser
    {
        public List<Player> ParseCSVFile(string filePath)
        {
            List<Player> players = new List<Player>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    int lineCount = 0;

                    //discard first line
                    if (!sr.EndOfStream) sr.ReadLine();

                    while ((line = sr.ReadLine()) != null)
                    {
                        lineCount++;
                        string[] fields = line.Split(',');
                        if (fields.Length == 21)
                        {
                            try
                            {
                                Player player = new Player();
                                {
                                    player.Name = fields[0];
                                    player.Team = fields[1];
                                    player.Pos = fields[2];
                                    player.GP = int.Parse(fields[3]);
                                    player.G = int.Parse(fields[4]);
                                    player.A = int.Parse(fields[5]);
                                    player.P = int.Parse(fields[6]);
                                    player.PlusMinus = int.Parse(fields[7]);
                                    player.PIM = int.Parse(fields[8]);
                                    player.PGP = double.Parse(fields[9]);
                                    player.PPG = int.Parse(fields[10]);
                                    player.PPP = int.Parse(fields[11]);
                                    player.SHG = int.Parse(fields[12]);
                                    player.SHP = int.Parse(fields[13]);
                                    player.GWG = int.Parse(fields[14]);
                                    player.OTG = int.Parse(fields[15]);
                                    player.S = int.Parse(fields[16]);
                                    player.SPercentage = double.Parse(fields[17]);
                                    player.TOIGP = fields[18];
                                    player.ShiftsGP = double.Parse(fields[19]);
                                    player.FOWPercentage = double.Parse(fields[20]);
                                };

                                players.Add(player);

                            }
                            catch (FormatException fe)
                            {
                                Console.WriteLine($"Error parsing line {lineCount}: {fe.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Line '{line}' does not contain the expected number of fields.");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading CSV file: " + ex.Message);
            }

            return players;
        }
    }
}