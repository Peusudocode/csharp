INSERT INTO 學號_宿舍 (學號,宿舍) VALUES
('E94091102', N'勝利')
INSERT INTO 學號_宿舍 (學號,宿舍) VALUES
('F12345678', N'不存在的宿舍')
INSERT INTO 姓名_學號_系級 (姓名,學號,系級) VALUES
(N'黃振庭','E94091102', N'資訊113')
INSERT INTO 姓名_學號_系級 (姓名,學號,系級) VALUES
(N'不存在的人','F12345678', N'資訊777')
INSERT INTO 姓名_期中考成績(姓名,期中考成績) VALUES
(N'黃振庭', 38)
INSERT INTO 姓名_期中考成績(姓名,期中考成績) VALUES
(N'不存在的人', 100)
SELECT 學號, 宿舍 FROM 學號_宿舍
SELECT 姓名,學號,系級 FROM 姓名_學號_系級
SELECT 姓名,期中考成績 FROM 姓名_期中考成績