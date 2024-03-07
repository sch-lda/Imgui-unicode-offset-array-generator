﻿using System;

public class Unicodegenerator
{
    public static int[] ChsToUnicode(string chstwraw)
    {
        int[] unicodeArray = new int[chstwraw.Length];

        for (int i = 0; i < chstwraw.Length; i++)
        {
            unicodeArray[i] = (int)chstwraw[i];
        }

        return unicodeArray;
    }

    public static void Main()
    {
        // 在下面一行添加未加入的中文字符
        string chstwraw = "牽護車灘緊邏輛務鐵擊監無標識腳線後熾餅塗輻龐驚盧爛搥爺際慾夠勝斬屍亞機藍岡農圖鬱齊勞納現災穀輓遊茲徹運輸國園鎮長動載單電費驅競業鑽礦碼頭裝攪傾廂貓屌聖環營幫瀾馬風羅經學獵門煉獄優樂雲渦輪隨龍貝薩維隻極鯊飆燈號潛纖級陽靈質義戰捲庫軍劍蟲夢魘與說專掛噴歐頓澤廢寬體脫騾殲滅壓創獨馱萬漢匯魯氣達損時紅祿熱殺將賽喬兹亂俠纜騎爭奪偵紹蠻奧節來嚇蘿褻瀆強異變鰭彈險盜噹鐘錐攔駭啞劇計髏齒爾惡狀衛溫錫開轎愛碩軸傑鬥毆雙鬧場倫統領禮萊鋼層飛復貨鳥灑藥華勁飽獅輕諾瑪獸閃衝凱寶陸語馳燄鷹騰鋒範總會樓壘灣設蘭區賭別舖蝕廣麥塢榮補給純潔偉劊鋪倉懸廠禦擾擴調組鑲邊側圓蓋釦製鏡頂階辦檢測員駕駛頻壞個傳關閉為發顯轉對麼啟這敗毀顏類戶寫鎖導點喚繞確認試進終過並尋團隊準備態換視讀當數據請離戲織聲夾該須編複應傘僅躍煙霧檔敵續斷實遠選擇訊輔內傷徑釋槍稱從鍵趕屬兩圍腦縫繼資軌間籠隱偽廳觀項們嗎網連緝帶問題滿執註冊繳凍結許閒種襲撿錢幀參適詳嘗條綴謹帳疊畫詢記錄嚴獲櫃觸處塊響錯誤贏詛棧暫鈕讓見東沒臨規則搶論剎鏢築竊樣漸穩較產餘繪蹤雜縮報價轟籤劑驗擋鑑閾欄潰橫滾搖桿飾舉議濾預訂瀏覽輯覺慣喪減遲賞卻佔權鋁漬還幾約壽儀虛島騷絕買訪牆協礙嚮歡髮褲錶況針銀刪購憑貼紀誌賠靜紋遙篩負責儲療鳴";
        int[] unicodeArray = ChsToUnicode(chstwraw);

        Array.Sort(unicodeArray);
        bool hasDuplicates = CheckDuplicates(unicodeArray);
        if (hasDuplicates)
        {
            Console.WriteLine("警告，存在重复元素");
        }

        for (int i = 0; i < unicodeArray.Length; i++)
        {
            if (i ==0)
            {
                Console.Write(unicodeArray[i] - 19968);
                Console.Write(", ");
            }
            else
            {
                Console.Write(unicodeArray[i] - unicodeArray[i-1]);
                Console.Write(", ");
            }

        }
    }

    public static bool CheckDuplicates(int[] array)
    {
        HashSet<int> set = new HashSet<int>();

        foreach (int element in array)
        {
            if (set.Contains(element))
            {
                char dplcChar = Convert.ToChar(element);
                string dplcText = dplcChar.ToString();
                Console.WriteLine("重复元素: " + element + " " + dplcText);
                return true;
            }

            set.Add(element);
        }

        return false;
    }
}
