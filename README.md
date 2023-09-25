# Gothic Fansub

New Turkish fansub group. Read Turkish Manga and Webtoons.


## API Usage

#### Get All (Manga)

```http
  GET /api/mangas/getall
```

| Parameter | Type    | Description              |
| :-------- | :------- | :------------------------- |
| - | `IDataResult` | Get all mangas from DB. |

#### Get By Id (Manga)

```http
  GET /api/mangas/getbyid?id=${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `IDataResult` | Get manga from DB by id.  |

#### Add (Manga)

```http
  POST /api/mangas/add
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `manga`      | `IResult` | Add manga to DB |
  
