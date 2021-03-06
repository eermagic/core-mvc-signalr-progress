# core-mvc-signalr-progress
[ASP.NET MVC][SignalR][Vue3] 即時回報進度百分比教學 #CH2

SignalR 是 ASP.NET 實現網頁雙向溝通的一種方式，傳統的網頁是單向溝通，只能由客戶端主動發送訊息至伺服器端，而雙向溝通就可以由伺服器端主動發送訊息至客戶端，可以解決網頁即時同步的問題。

SignalR 應用的場景非常多，舉凡需要即時同步的需求都適合，例如遊戲、股價、聊天室、投票、拍賣、監控等等，如果學會此技能，將可在網頁上做出更豐富的變化。

此範例模擬場景是某一按鈕執行時間過長，使用者不知道何時結束，容易因為等待太久，懷疑是否當機，而直接關閉網頁離開。
如果可以即時告知使用者目前執行進度百分比的話，因為可預期何時結束，也知道系統正在執行沒有當機，讓使用者願意等待直到執行完畢。

範例環境是ASP.NET Core SignalR 搭配 Vue3 的使用方式，適合有使用 Vue3 前端的朋友使用。

[完整教學文章](https://blog.hungwin.com.tw/core-mvc-signalr-progress/)
