﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string theText = @" 1   1 0     0
  2   1 1     1
  3   2 11     3
  4   3 101     5
  5   3 111     7
  6   4 1001     9
  7   6 100001     33
  8   7 1100011     99
  9   9 100111001     313
 10  10 1001001001     585
 11  10 1011001101     717
 12  13 1110100010111     7447
 13  14 10001100110001     9009
 14  14 11101111110111     15351
 15  15 111110111011111     32223
 16  16 1001110000111001     39993
 17  16 1100111111110011     53235
 18  16 1101001001001011     53835
 19  17 10010000000001001     73737
 20  20 10001110111101110001     585585
 21  21 110101101010101101011     1758571
 22  21 111011000010000110111     1934391
 23  21 111100011010110001111     1979791
 24  22 1011111011111101111101     3129213
 25  23 10011010110001101011001     5071705
 26  23 10100000100000100000101     5259525
 27  23 10110010010001001001101     5841485
 28  24 110011100000000001110011     13500531
 29  30 101010111010000000010111010101     719848917
 30  30 110110010000110011000010011011     910373019
 31  30 110111111111110011111111111011     939474939
 32  31 1001100111100010100011110011001     1290880921
 33  33 110111100000111101111000001111011     7451111547
 34  34 1001010111000101001010001110101001     10050905001
 35  35 10001001100011011011011000110010001     18462126481
 36  35 11110001111111010101011111110001111     32479297423
 37  37 1000101110111010000000101110111010001     75015151057
 38  37 1100111010101000100010001010101110011     110948849011
 39  37 1111111001001100011100011001001111111     136525525631
 40  41 10001111101010110010101001101010111110001     1234104014321
 41  41 10100100100110011000000011001100100100101     1413899983141
 42  41 10101011101101000001110000010110111010101     1474922294741
 43  41 11010000101100101011111010100110100001011     1792704072971
 44  41 11010000110111000100000100011101100001011     1794096904971
 45  41 11101000110100100110101100100101100010111     1999925299991
 46  43 1010010010000011010100010101100000100100101     5652622262565
 47  43 1101001001011001010001000101001101001001011     7227526257227
 48  43 1101010000000011010111110101100000000101011     7284717174827
 49  44 10001010000001011110100101111010000001010001     9484874784849
 50  45 111110000110100101001010100101001011000011111     34141388314143
 51  49 1111101100011110000000000000000000111100011011111     552212535212255
 52  50 11010100001010111100110100101100111101010000101011     933138363831339
 53  51 110010111110110110011001101100110011011011111010011     1793770770773971
 54  52 1011001011111111010101100110011010101111111101001101     3148955775598413
 55  54 100101001001110001111011010010110111100011100100101001     10457587478575401
 56  54 100110011100000110111100101101001111011000001110011001     10819671917691801
 57  55 1000000111100010000110111110111110110000100011110000001     18279440804497281
 58  55 1111001001010011101100010000000100011011100101001001111     34104482028440143
 59  56 10000011101110101111100000100100000111110101110111000001     37078796869787073
 60  56 10000101101100000011100000100100000111000000110110100001     37629927072992673
 61  56 11000110110010001010000010000001000001010001001101100011     55952637073625955
 62  58 1000111100101110000010010000110000100100000111010011110001     161206152251602161
 63  59 10001011001111110110111101010101010111101101111110011010001     313558153351855313
 64  63 110000110100101110101111010101111101010111101011101001011000011     7036267126217626307
 65  64 1000011001000100000010011101100000011011100100000010001001100001     9674868723278684769
 66  64 1001011011111100100110100001101111011000010110010011111101101001     10879740244204797801
 67  65 11100100001110000100010111100110001100111101000100001110000100111     32889941788714998823
 68  67 1010010001101001111101010000000010100000000101011111001011000100101     94778157422475187749
 69  67 1100011001011111011011101111101010101011111011101101111101001100011     114354126121621453411
 70  69 111010011111010111001011000001011010110100000110100111010111110010111     539475328171823574935
 71  74 11101100101001110111101010100001100011000110000101010111101110010100110111     17461998948684989916471
 72  76 1111011100010111000010001000100000001001000000010001000100001110100011101111     72928088195859188082927
 73  77 10011101011001101100001111001011011101110111011010011110000110110011010111001     92913401775957710431929
 74  77 10011111101011111000101010110000101100000110100001101010100011111010111111001     94261805583838550816249
 75  80 11101111011000111100010111011101101100100100110110111011101000111100011011110111     1130486074817184706840311
 76  80 11111100111001111110000011110100111000100100011100101111000001111110011100111111     1194313761393931673134911
 77  81 100000010001011100111110110101100111111101111111001101011011111001110100010000001     1219228158701078518229121
 78  83 10011001110111100101011110111001110100001110000101110011101111010100111101110011001     5812988563013103658892185
 79  83 11000000001100100101111110001001011010100100101011010010001111110100100110000000011     7260988688520258868890627
 80  83 11000101111000010101010110100001110100000100000101110000101101010101000011110100011     7475703079870789703075747
 81  86 10101000001010100000100110101010101001100000000110010101010101100100000101010000010101     50824513851188115831542805
 82  87 111001011000111001101111010110010111011100111001110111010011010111101100111000110100111     138758321383797383123857831
 83  89 10010001001101011010101000000110111100000100000100000111101100000010101011010110010001001     351095331428353824133590153
 84  89 10100001100110001000000111100001100011000111011100011000110000111100000010001100110000101     390714505091666190505417093
 85  89 11011100000100000001001010010000011001110101010101110011000001001010010000000100000111011     532079161251434152161970235
 86  89 11100100101100110101011000010001001111100100100100111110010001000011010101100110100100111     552963956270141072659369255
 87  90 101001000111010111001110010101001010000101000000101000010100101010011100111010111000100101     795280629691202196926082597
 88  91 1010011001011111011111100001110110010000000100010000000100110111000011111101111101001100101     1609061098335005338901609061
 89  94 1110011011110110001110101001000001000000000011001100000000001000001001010111000110111101100111     17869806142184248124160896871
 90  94 1111111101011000000101011001100101101101100001111000011011011010011001101010000001101011111111     19756291244127372144219265791
 91  95 11000001110111110100001110001010010000110100011011000101100001001010001110000101111101110000011     30000258151173237115185200003
 92  95 11000110001000000010110011101000100010000101111111110100001000100010111001101000000010001100011     30658464822225352222846485603
 93  96 101101101010101001110101110101101111011010100000000001010110111101101011101011100101010101101101     56532345659072227095654323565
 94  99 100110001011001001110111010000000001110111000111010111000111011100000000010111011100100110100011001     378059787464677776464787950873
 95 100 1110000101010101000110001001111111101011111110110110110111111101011111111001000110001010101010000111     1115792035060833380605302975111
 96 102 101010110011000001001111000000100001000111101001011110100101111000100001000000111100100000110011010101     3390741646331381831336461470933
 97 103 1011010010100010100000100100110111011100110000100000000010000110011101110110010010000010100010100101101     7155681676104835384016761865517
 98 108 100101001110000100000011000000011101011010000111111001100111111000010110101110000000110000001000011100101001     188726493036450333054630394627881
 99 109 1000001101011000000111101011111010011111110010111111110111111110100111111100101111101011110000001101011000001     332997156422555464555224651799233
100 109 1110010010101111000010000000101101110101110101111110010100111111010111010111011010000000100001111010100100111     579782100975917393719579001287975
101 111 100010101111101111001011011110110000100110111101111101111101111101111011001000011011110110100111101111101010001     1409460884147943003497414880649041
102 111 100100100000011001100111010000100000111000101000010010101010010000101000111000001000010111001100110000001001001     1480869563960100770010693659680841
103 113 11110100110110110000110000111111001110101110110100100110101100100101101110101110011111100001100001101101100101111     9932525402284695775964822045252399
104 114 100000110100110000011001000011010100110111001111111010100001010111111100111011001010110000100110000011001011000001     10652099006552766666725560099025601
105 114 100001010111010111111000100101110101000001101110111000000000000111011101100000101011101001000111111010111010100001     10827628430039640604693003482672801
106 116 10100110101000011001101101000110100100010010100111010001000010001011100101001000100101100010110110011000010101100101     54074940541725088788052714504947045
107 116 11101100100010001100100111000111101110000000111101011110111101111010111100000001110111100011100100110001000100110111     76759778311938325452383911387795767
108 117 100100010100010100110101110000011000101111001111001010100101001010100111100111101000110000011101011001010001010001001     94285848717805140304150871784858249
109 117 100101010001001100000010001001011010110010111110000001011010110100000011111010011010110100100010000001100100010101001     96754720977532710701723577902745769
110 117 110101100101101011100001111100010101001010100000101110011010110011101000001010100101010001111100001110101101001101011     139124355701640720027046107553421931
111 120 100010001100000111011011000001010110000011110100110011101001100101110011001011110000011010100000110110111000001100010001     710084230446469950059964644032480017
112 120 100110001111111011010110010010110011100000110100011011010110011010110110001011000001110011010010011010110111111100011001     794397832642722540045227246238793497
113 120 110000000011011000111101011111110111001001111010100001010011110010100001010111100100111011111110101111000110110000000011     998021119318189842248981813911120899
114 120 111111101110010001100000110000001011101110000100010011011001100110110010001000011101110100000011000001100010011101111111     1323475457008895965695988007545743231
115 121 1010000111110100001011100011010010000100000001001100100000111110000010011001000000010000100101100011101000010111110000101     1681824725831390428240931385274281861
116 123 100011011110001111100110111011011000000011010001101100111101101101111001101100010110000000110110111011001111100011110110001     5893890080115984244424895110800983985
117 123 111010011011011000101001111110111011010000110111010111101000111000101111010111011000010110111011111100101000110110110010111     9707999142717984907094897172419997079
118 123 111100000000011101000001101111110000110101100111000001101101101101101100000111001101011000011111101100000101110000000001111     9970387454991896491946981994547830799
119 125 11000001101111001100101010101110011101011101101110101100001011011010000110101110110111010111001110101010100110011110110000011     32190158233101105022050110133285109123 
120 127 1011011111101101011100111110001001111001110001100111000010000101010000100001110011000111001111001000111110011101011011111101101     122240824002234545959545432200428042221
121 127 1011101011011101001011100011110110110011001011010010000001000110110001000000100101101001100110110111100011101001011101101011101     124192421350471300727003174053124291421
122 127 1100011000011111001001111110101101011010100110011111011010111000001110101101111100110010101101011010111111001001111100001100011     131674457014330218696812033410754476131
123 129 110011111000011011001000100100101000110001100100000110010010100101001010010011000001001100011000101001001000100110110000111110011     551700061998405245575542504899160007155
124 130 1001000101111111111100101011111011001100011000110110000111111000000001111110000110110001100011001101111101010011111111111010001001     773609618198307097595790703891816906377 
125 130 1011111101011011000100110111110111011110111111100010000000011111111111100000000100011111110111101110111110110010001101101011111101     1017421766189445102992015449816671247101
126 131 10011001101101110100000100001000001100011100101110011110001110100000101110001111001110100111000110000010000100000101110110110011001     1634587141488515712882175158841417854361
127 133 1010011101000101010010110110101101011101000100000110001101110010110110100111011000110000010001011101011010110110100101010001011100101     7114907950920173924554293710290597094117
128 134 10101000011010110000011011100110011010100011111101011110100110011100111001100101111010111111000101011001100111011000001101011000010101     14327425216354951264146215945361252472341
129 135 101110011111000110110100100110000011011010101010010000010001011110010011110100010000010010101010110110000011001001011011000111110011101     31636759764024794204540249742046795763613";

            string[] lines = theText.Split(new string[] { "\r\n", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 3; i <= lines.Length; i += 4)
            {
                Console.Write($"{lines[i]}, ");
            }
        }
    }
}