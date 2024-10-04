namespace LinkAce.NET.Tests;

public class TestData
{
    public const string TestApiKey = "testing-token";
    public const string SearchLinkResponseJson = @"{
    ""current_page"": 1,
    ""data"": [
        {
            ""check_disabled"": false,
            ""created_at"": ""2020-09-21T21:39:11.000000Z"",
            ""deleted_at"": null,
            ""description"": ""Pictures from my Atreus keyboard build"",
            ""icon"": ""link"",
            ""id"": 1098,
            ""is_private"": false,
            ""status"": 1,
            ""tags"": [
                {
                    ""created_at"": ""2023-06-09T16:16:36.000000Z"",
                    ""deleted_at"": null,
                    ""id"": 603,
                    ""is_private"": false,
                    ""name"": ""atreus"",
                    ""pivot"": {
                        ""link_id"": 1098,
                        ""tag_id"": 603
                    },
                    ""updated_at"": ""2023-06-09T16:16:36.000000Z"",
                    ""user_id"": 1
                },
                {
                    ""created_at"": ""2023-06-09T16:07:30.000000Z"",
                    ""deleted_at"": null,
                    ""id"": 234,
                    ""is_private"": false,
                    ""name"": ""diy"",
                    ""pivot"": {
                        ""link_id"": 1098,
                        ""tag_id"": 234
                    },
                    ""updated_at"": ""2023-06-09T16:07:30.000000Z"",
                    ""user_id"": 1
                },
                {
                    ""created_at"": ""2023-06-09T16:16:37.000000Z"",
                    ""deleted_at"": null,
                    ""id"": 605,
                    ""is_private"": false,
                    ""name"": ""keyboard"",
                    ""pivot"": {
                        ""link_id"": 1098,
                        ""tag_id"": 605
                    },
                    ""updated_at"": ""2023-06-09T16:16:37.000000Z"",
                    ""user_id"": 1
                }
            ],
            ""thumbnail"": null,
            ""title"": ""Classic Atreus Build - jphotos"",
            ""updated_at"": ""2023-06-09T16:16:37.000000Z"",
            ""url"": ""https://photos.jrgnsn.net/album/classic-atreus-build"",
            ""user_id"": 1
        }
    ],
    ""first_page_url"": ""https://links.fminus.co/api/v1/search/links?page=1"",
    ""from"": 1,
    ""last_page"": 1,
    ""last_page_url"": ""https://links.fminus.co/api/v1/search/links?page=1"",
    ""links"": [
        {
            ""active"": false,
            ""label"": ""&laquo; Previous"",
            ""url"": null
        },
        {
            ""active"": true,
            ""label"": ""1"",
            ""url"": ""https://links.fminus.co/api/v1/search/links?page=1""
        },
        {
            ""active"": false,
            ""label"": ""Next &raquo;"",
            ""url"": null
        }
    ],
    ""next_page_url"": null,
    ""path"": ""https://links.fminus.co/api/v1/search/links"",
    ""per_page"": 24,
    ""prev_page_url"": null,
    ""to"": 1,
    ""total"": 1
}";
    public const string CreateLinkResponseJson = @"{
    ""check_disabled"": false,
    ""created_at"": ""2024-10-04T19:32:31.000000Z"",
    ""description"": ""A test link"",
    ""icon"": ""link"",
    ""id"": 1819,
    ""is_private"": false,
    ""lists"": [],
    ""status"": 0,
    ""tags"": [
        {
            ""created_at"": ""2023-06-13T23:27:14.000000Z"",
            ""deleted_at"": null,
            ""id"": 880,
            ""is_private"": false,
            ""name"": ""test"",
            ""pivot"": {
                ""link_id"": 1819,
                ""tag_id"": 880
            },
            ""updated_at"": ""2023-06-13T23:27:14.000000Z"",
            ""user_id"": 1
        }
    ],
    ""thumbnail"": null,
    ""title"": ""Test Link"",
    ""updated_at"": ""2024-10-04T19:32:31.000000Z"",
    ""url"": ""https://jrgnsn.net"",
    ""user_id"": 1
}";
}
