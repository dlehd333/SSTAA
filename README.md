# SSTAA : Subway Station Trading
# ����

- C# .NET Framework�� EntityFramework �� DevExpress�� �̿��� ����� �� �� ���� ��Ǻм��� ���α׷��� �����Ͽ���.

# ���� �Ⱓ

- 2020�� 12�� 28�� ~ 2021�� 01�� 08��

# ���� �ο�

- IoT��� ����Ʈ���丮 SW���� ����������
- ����, �ȼ���, �̵��� �� 3��

# �ֿ� ���

## ��� ���

### ��õ����� ������� �� ����(�����)

<div>
<a href="./Document/screen/����ȭ��.png" target="_blank">
<img src="./Document/screen/����ȭ��.png" width="32%">
</a>
<a href="./Document/screen/�ش籸�׾�������ȭ��.png" target="_blank">
<img src="./Document/screen/�ش籸�׾�������ȭ��.png" width="32%">
</a>
<a href="./Document/screen/�ε�ȭ��.png" target="_blank">
<img src="./Document/screen/�ε�ȭ��.png" width="32%">
</a>
</div>

- �ش籸 ����, ���� ����
- �ش籸 ���� ����� DevExpress Mapcontrol�� ����


### �ش籸 ������ ������

<div>
<a href="./Document/screen/����������������õ������.png" target="_blank">
<img src="./Document/screen/����������������õ������.png" width="32%">
</a>
</div>

- ���õ� ���� �ش�Ǵ� ����ö�� ������ ������ ��õ

### ������ ������ ���γ���

<div>
<a href="./Document/screen/���ÿ����γ���.png" target="_blank">
<img src="./Document/screen/���ÿ����γ���.png" width="32%">
</a>
</div>

- ����ö�� ����Ŭ���� �ش翪 ���γ��� ���

## ������ ����
 
<div>
<a href="./Document/screen/���ľȳ�.png" target="_blank">
<img src="./Document/screen/���ľȳ�.png" width="32%">
</a>
</div>

- �ش系�� �̽� #7 ����

## �Է� ���

- Excel(.xls).csv ���� DB ���� ���

<a href="./Document/�ֿ���/����������.jpg" target="_blank">
<img src="./Document/�ֿ���/����������.jpg" width="32%">
</a>

- �ش� ������ ���� ���� �� ����(DB)�� ���� ����

# ��� ���

## ���

- C# 8.0

## �����ӿ�ũ

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

## �����ͺ��̽�

* MSSQL Server 2019

## Third Party

- DevExpress 20.2.3 (Trial Version)

## ��Ÿ ����ȯ��

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# �����ͺ��̽� ��Ű��
![D B��Ű��](Document/DB��Ű��.png)

- ��� �׸��� �� 3 ����ȭ���� �Ϸ�ƴ�

# ���� ���̽� ���̾�׷�
![�������̾�׷�](Document/�������̾�׷�.png)


# �÷ο���Ʈ
![�÷ο���Ʈ](Document/�÷ο���Ʈ.png)


# Ŭ���� ���̾�׷�

## DAO(Data Access Object)



# ������ ���̾�׷�

## ���� ���� ������



# Point of Interest

# ������ �۵��Ǵ� �ð��� �ʹ� ���� �ɸ��� ���� [#42](https://github.com/dlehd333/SSTAA/issues/42)

## ����(����)

- ������ �۵��Ǵ� �ð��� �ʹ� ���� �ɸ��� ����

## ����

- �ۼ��� ������ �ڵ�� �Է��Ͽ� ���� ����� �����Ͽ��µ�, �ð��� �ʹ� �����ɷȴ�
- ���빮��, Ŀ�������� ���� �� 2��
- ������ ����� ���� ���� DB�� ����, Ư���� ��ġ�� ū DB�� �����ϴ� Ƚ���� ���� ������ �Ǵ��ߴ�.

## ���(�ذ���)

- DB�� �����ϴ� Ƚ���� ������ ���� ������ ���̶� �Ǵ��Ͽ�, ������ �۵���Ű�� ���� �ʿ��� �����͸� ���� DB�� �����Ͽ� �޾ƿ� ���� ������ ����Ǵ� ���ȿ��� DB�� �������� �ʵ��� ���α׷�����
- �� ���, ���� �̻����� �ð��� ���̴� �� ������
- ���빮��, Ŀ�������� ���� �� 12��

## ������ �ڵ峪 ��ũ����

```c#
public List<AnnualEvaluationScoreModel> GetAnnualEvaluationScoreModels(int upperLocationId, int fieldId)
{
  // �̸� DB�� �����Ͽ� �ʿ��� ��ŭ �����͸� �������� �κ�
  List<Station> stations = Dao.Station.GetByUpperLocation(upperLocationId);
  List<LandPriceIndex> landPriceIndices = Dao.LandPriceIndex.GetByLocation(upperLocationId);
  List<Competitor> competitors = Dao.Competitor.GetByField(fieldId);
  // ����� �����Ͽ� ���� �����ϴ� �κ�. DB�� ������ ���� ���� �÷����� �����ͷ� ����� �����Ѵ�
  List<AnnualEvaluationScoreModel> models = new List<AnnualEvaluationScoreModel>();
  foreach(var station in stations)
  {
    // ...
  }
  // ...
  return models;
}
```
---

# SHP ������ �̿��� MapControl�� ���� ������ �о���� ���� [#41](https://github.com/dlehd333/SSTAA/issues/41)

## ����(����)

- MapControl���� ������ ������ ������ ��, �ش� ������ �����͸� shp���Ͽ��� �о������ ������ ����� ã�� ���Ͽ���.

## ����

- shp ������ ����� ������ ���°� �ƴϾ���.
- MapControl���� Region, MapItem, Object�� �������� ���Ͽ���.
- ���ϴ� �����Ϳ� �����ϴ� ����� ã������ �ߴ�.

## ���(�ذ���)

- shp ������ 3�� ������ ���ϵ��� ������ vector ������ ��� ���� �����Ͽ���. ����, �� ��ҵ��� �����Ͽ�, ���ϴ� �����Ϳ� �����ϱ� ���ؼ� �ʿ��� ��Ҹ� �˾Ƴ�����.
- �ش� ������ MapItem.Data.Attributes�� ������ �� �־�����, ��������(binary reading)���� ����Ǿ� �־��⿡ ���ڵ��� �ʿ��ߴ�.
- shapeFileAdapter�� �̿��� vectorItemsLayer�� �ش� �����͸� load�� �� �ʿ��� �������� ���ڵ��� �� ��, ���� �ҷ��� �����͸� string���� ĳ�����Ͽ� �ʿ��� ���� ����Ͽ���.

##������ �ڵ峪 ��ũ����

![����Ʈ��](Document/screen/����Ʈ��.png)

```c#
shapefileDataAdapter1.DefaultEncoding = Encoding.GetEncoding(51949);
            shapefileDataAdapter1.FileUri = new Uri(_path[0], UriKind.Absolute);

            mapControl1.CenterPoint = new GeoPoint(37.5656754986042d, 126.98202985079d);
            mapControl1.ZoomLevel = 10.8d;

            vectorItemsLayer1.ItemStyle.Fill = Color.FromArgb(90, Color.White);
            vectorItemsLayer1.ItemStyle.Stroke = Color.White;
            vectorItemsLayer1.SelectedItemStyle.Fill = Color.FromArgb(120, Color.Blue);
```

---

# ũ�Ⱑ ū �����͸� �Ѳ����� DB�� ������ �� �޸� ������ �߻��ϴ� ���� [#23](https://github.com/dlehd333/SSTAA/issues/23)

## ����(����)

- csv file�� ������ DB�� �����Ϸ��µ�, �޸� ������ �߻�

## ����

- FootTraffic ���̺� �� csv���� �����͸� EF�� �̿��� �����Ϸ��� �ߴµ�, ���α׷��� ������� ������� �ʴ� ������ �߻�
- ���� �ذ��� ���� ó������ ���� �����ϴ� ��� Query���� ����� SQL���Ϸ� SSMS�� �̿��� �����Ϸ��� ��
- ������ SSMS������ Query���� �ʹ� �� �޸� ������ �߻�(SSMS�� 32bit�� �۵��ϱ� ������ ������ ������)

## ���(�ذ���)

- �׷��� �����԰� ������ ���, �ش� CSV������ �����͸� ���� �о �Ѳ����� �Է��ϴ� ���� �ƴ϶� �� �پ� �о �Է��ϴ� ������� ������
- ��� ������� ������ �������� DB�� ���� ���� �ְ�, Visual Studio ����� ����� ���� ������ ���� �޸� ������ �߻����� �ʴ°��� Ȯ����

## ������ �ڵ峪 ��ũ����

```c#
// before
for(int i = 0;i < rows.Count;i++)
{
  // ...
}
// for������ ������ ������ ���� �о���� ���� DB�� �Է�
using (var context = DbContextCreator.Create())
{
  context.FootTraffics.AddRange(footTraffics);
  context.SaveChanges();
}
// -----------------------------------------------------------------
// after
for(int i = 0;i < rows.Count;i++)
{
  // ...
  // �� ���� ���� ���� DB�� �Է�
  using (var context = DbContextCreator.Create())
  {
    context.FootTraffics.AddRange(footTraffics);
    context.SaveChanges();
  }
}
```
![������](Document/screen/������.png)

---

# ���� ����� ���� ��Ʈ���� �ٸ� ��Ʈ���� ������ ���� [#9](https://github.com/dlehd333/SSTAA/issues/9)

## ����(����)

- ���� ��Ʈ���� �����ϰ� ���� �ٸ� ��Ʈ���� ������ �ʴ� ����

## ����

- �ε� �ÿ� ��µǴ� �˾� ������ ��Ʈ���� ����� �;��µ�, �ֺ� �ٸ� ��Ʈ���� �۵����� �ʵ��� �ϰ� �;���
- �׷��� ���� ��Ʈ���� ����� ����� Transparent�� ������ ���� �˾� ������ �� Panel�� �������.
- ���Ŀ� ���� �ҷ��Դµ�, ���� �ִ� �ٸ� ��Ʈ���� �������� ������ �߻��ߴ�

## ���(�ذ���)

- �׷��� ��Ʈ���� �����ϰ� �� �ٸ� ����� ã�ƺ��⵵ �ϰ�, DevExpress���� �����ϴ� XtraUserControl�� �������� Ȯ���غ����� ���� ����� ���Դ�.
- �ᱹ, �˾��� ������ �ٽ� �����, ���� ShowDialog�� ����Ͽ� �ٸ� ��Ʈ���� ������� �ʵ��� �ϴ� ������� ��ȸ�ϱ�� �ߴ�.
- ���� ��Ʈ���� �����ϰ� ����� �ٸ� ��Ʈ���� ��ġ���� �������� ���ϴ� ���¸� �����ϱ� ��������, ���� ��Ʈ�ѵ� ��Ʈ���̱� ������ �⺻������ �ڽź��� �Ʒ��� �ִ� ��Ʈ���� �����ٴ� ����� �˰� �Ǿ���.

## ������ �ڵ峪 ��ũ����
![�ε�����](Document/screen/�ε�����.png)