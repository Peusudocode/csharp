UPDATE 學號_宿舍
SET 宿舍 = N'光復'
WHERE 學號 = 'F12345678'
UPDATE 姓名_學號_系級
SET 系級 = N'資訊123'
WHERE 姓名 = N'不存在的人'
UPDATE 姓名_期中考成績
SET 期中考成績 = 105
WHERE 姓名 = N'不存在的人'
SELECT 學號, 宿舍 FROM 學號_宿舍
SELECT 姓名,系級 FROM 姓名_學號_系級
SELECT 姓名,期中考成績 FROM 姓名_期中考成績