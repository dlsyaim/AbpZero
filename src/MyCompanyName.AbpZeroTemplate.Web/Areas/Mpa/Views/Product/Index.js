(function () {
    $(function () {

        var _$categoriesTable = $('#ProductsTable');
        var _categoryService = abp.services.app.product;

        _$categoriesTable.jtable({
            title: app.localize('ProductsTable'),//标题
            paging: true,//启用分页
            sorting: true,//启用排序
            multiSorting: true,//启用多列排序
            actions: {
                listAction: {
                    method: _categoryService.getProductListAsync//获取列表方法
                }
            },
            fields: {
                id: {
                    key: true,
                    list: false
                },
                //actions: {
                //    title: app.localize('Actions'),//操作列
                //    width: '15%',
                //    sorting: false
                //},
                name: {
                    title: app.localize('Name'),
                    width: '20%'
                }
            }
        });
        //获取列表
        function getCategories(reload) {
            if (reload) {
                _$categoriesTable.jtable('reload');
            } else {
                _$categoriesTable.jtable('load');
            }
        }
        //页面加载完执行
        getCategories();
    });
})();