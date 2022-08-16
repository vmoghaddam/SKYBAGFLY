'use strict';
app.controller('FatigueReportController', ['$scope', '$rootScope', '$window', function ($scope, $rootScope, $window) {

    $scope.isFullScreen = true;

    $scope.entity = {
        Id: -1,
    };

    $scope.popup_add_visible = false;
    $scope.popup_height = $(window).height() - 300;
    $scope.popup_width = $(window).width() - 0;
    $scope.popup_add_title = 'Fatigue Report';
    $scope.popup_instance = null;

    $scope.popup_add = {


        showTitle: true,

        toolbarItems: [
            
            {
                widget: 'dxButton', location: 'before', options: {
                    type: 'default', text: 'Sign', icon: 'fas fa-signature', onClick: function (e) {
                        if ($rootScope.getOnlineStatus()) {
                            $rootScope.checkInternet(function (st) {
                                if (st) {
                                    var data = { FlightId: $scope.entity.FlightId, documentType: 'asr' };

                                    $rootScope.$broadcast('InitSignAdd', data);
                                }
                                else {
                                    General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                                }
                            });

                        }
                        else {
                            General.ShowNotify("You are OFFLINE.Please check your internet connection", 'error');
                        }

                    }
                }, toolbar: 'bottom'
            },

            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'default', text: 'Save', icon: 'check', validationGroup: 'toadd', onClick: function (e) {

                        if ($scope.fidgeting) {
                            $scope.entity.fidgeting = 1;
                        }
                        if ($scope.attention) {
                            $scope.entity.attention = 1;
                        }
                        if ($scope.attention) {
                            $scope.entity.attention = 1;
                        }
                        if ($scope.rubbingEyes) {
                            $scope.entity.rubbingEyes = 1;
                        }
                        if ($scope.memory) {
                            $scope.entity.memory = 1;
                        }
                        if ($scope.yawing) {
                            $scope.entity.yawing = 1;
                        }
                        if ($scope.problemSolving) {
                            $scope.entity.problemSolving = 1;
                        }
                        if ($scope.blinking) {
                            $scope.entity.blinking = 1;
                        }
                        if ($scope.riskTaking) {
                            $scope.entity.riskTaking = 1;
                        }
                        if ($scope.staringBlankly) {
                            $scope.entity.staringBlankly = 1;
                        }
                        if ($scope.longBlinks) {
                            $scope.entity.longBlinks = 1;
                        }
                        if ($scope.negativeMood) {
                            $scope.entity.negativeMood = 1;
                        }
                        if ($scope.keepingEyes) {
                            $scope.entity.keepingEyes = 1;
                        }
                        if ($scope.reducedCommunication) {
                            $scope.entity.reducedCommunication = 1;
                        }
                        if ($scope.headNodding) {
                            $scope.entity.headNodding = 1;
                        }
                        if ($scope.fullyAlert) {
                            $scope.entity.fullyAlert = 1;
                        }
                        if ($scope.lively) {
                            $scope.entity.lively = 1;
                        }
                        if ($scope.fresh) {
                            $scope.entity.fresh = 1;
                        }
                        if ($scope.littleTired) {
                            $scope.entity.littleTired = 1;
                        }
                        if ($scope.almostTired) {
                            $scope.entity.almostTired = 1;
                        }
                        if ($scope.veryTired) {
                            $scope.entity.veryTired = 1;
                        }
                        if ($scope.exhausted) {
                            $scope.entity.exhausted = 1;
                        }

                      


                    }
                }, toolbar: 'bottom'
            },
            {
                widget: 'dxButton', location: 'after', options: {
                    type: 'danger', text: 'Close', icon: 'remove', onClick: function (e) {
                        $scope.popup_add_visible = false;
                    }
                }, toolbar: 'bottom'
            }
        ],

        visible: false,
        dragEnabled: true,
        closeOnOutsideClick: false,
        onShowing: function (e) {
            $rootScope.IsRootSyncEnabled = false;
            $scope.popup_instance.repaint();


        },
        onShown: function (e) {

            if ($scope.isNew) {
                $scope.isContentVisible = true;
            }
            if ($scope.tempData != null)
                $scope.bind();





        },
        onHiding: function () {
            $rootScope.IsRootSyncEnabled = true;
            //$scope.clearEntity();
            $scope.entity = {
                Id: -1,


            };
            $scope.popup_add_visible = false;
            $rootScope.$broadcast('onFatigueReportHide', null);
        },
        onContentReady: function (e) {
            if (!$scope.popup_instance)
                $scope.popup_instance = e.component;

        },
        // fullScreen:false,
        bindingOptions: {
            visible: 'popup_add_visible',
            fullScreen: 'isFullScreen',
            title: 'popup_add_title',
            height: 'popup_height',
            width: 'popup_width',
            'toolbarItems[1].visible': 'isLockVisible',
            'toolbarItems[2].visible': 'isEditable',

        }
    };




    ////////////////////////////

    $scope.scroll_FatigueReport_height = $(window).height() - 130;
    $scope.scroll_FatigueReport = {
        width: '100%',
        bounceEnabled: false,
        showScrollbar: 'never',
        pulledDownText: '',
        pullingDownText: '',
        useNative: true,
        refreshingText: 'Updating...',
        onPullDown: function (options) {

            options.component.release();

        },
        onInitialized: function (e) {


        },
        bindingOptions: {
            height: 'scroll_FatigueReport_height'
        }

    };
    var appWindow = angular.element($window);
    appWindow.bind('resize', function () {
        //alert('w: '+$(window).width());

        $scope.$apply(function () {
            $scope.scroll_FatigueReport_height = $(window).height() - 130;
        });
    });

    ////////////////////////////

    $scope.txt_reporterName = {
        bindingOptions: {
            value:"entity.reporterName"
        }
    }

    $scope.txt_rank = {
        bindingOptions: {
            value: "entity.rank"
        }
    }

    $scope.txt_posInFlight = {
        bindingOptions: {
            value: "entity.posInFlight"
        }
    }
    $scope.txt_maxDuty = {
        bindingOptions: {
            value: "entity.maxDuty"
        }
    }
    $scope.txt_totalDuty = {
        bindingOptions: {
            value: "entity.totalDuty"
        }
    }
    $scope.txt_reqRest = {
        bindingOptions: {
            value: "entity.reqRest"
        }
    }
    $scope.txt_actRest = {
        bindingOptions: {
            value: "entity.actRest"
        }
    }

    $scope.fidgeting = false;
    $scope.txt_fidgeting = {
        bindingOptions: {
            value: "fidgeting"
        }
    }

    $scope.attention = false;
    $scope.txt_attention = {
        bindingOptions: {
            value: "attention"
        }
    }

    $scope.rubbingEyes = false;
    $scope.txt_rubbingEyes = {
        bindingOptions: {
            value: "rubbingEyes"
        }
    }

    $scope.memory = false;
    $scope.txt_memory = {
        bindingOptions: {
            value: "memory"
        }
    }

    $scope.yawing = false;
    $scope.txt_yawing = {
        bindingOptions: {
            value: "yawing"
        }
    }

    $scope.problemSolving = false;
    $scope.txt_problemSolving = {
        bindingOptions: {
            value: "problemSolving"
        }
    }

    $scope.blinking = false;
    $scope.txt_blinking = {
        bindingOptions: {
            value: "blinking"
        }
    }

    $scope.riskTaking = false;
    $scope.txt_riskTaking = {
        bindingOptions: {
            value: "riskTaking"
        }
    }

    $scope.staringBlankly = false;
    $scope.txt_staringBlankly = {
        bindingOptions: {
            value: "staringBlankly"
        }
    }

    $scope.awareness = false;
    $scope.txt_awareness = {
        bindingOptions: {
            value: "awareness"
        }
    }

    $scope.longBlinks = false;
    $scope.txt_longBlinks = {
        bindingOptions: {
            value: "longBlinks"
        }
    }

    $scope.negativeMood = false;
    $scope.txt_negativeMood = {
        bindingOptions: {
            value: "negativeMood"
        }
    }

    $scope.keepingEyes = false;
    $scope.txt_keepingEyes = {
        bindingOptions: {
            value: "keepingEyes"
        }
    }

    $scope.headNodding = false;
    $scope.txt_headNodding = {
        bindingOptions: {
            value: "headNodding"
        }
    }

    $scope.reducedCommunication = false;
    $scope.txt_reducedCommunication = {
        bindingOptions: {
            value: "reducedCommunication"
        }
    }
    $scope.txt_other = {
        bindingOptions: {
            value: "entity.other"
        }
    }


    $scope.fullyAlert = false;
    $scope.txt_fullyAlert = {
        bindingOptions: {
            value: "fullyAlert"
        }
    }

    $scope.lively = false;
    $scope.txt_Lively = {
        bindingOptions: {
            value: "lively"
        }
    }

    $scope.fresh = false;
    $scope.txt_Fresh = {
        bindingOptions: {
            value: "fresh"
        }
    }

    $scope.littleTired = false;
    $scope.txt_littleTired = {
        bindingOptions: {
            value: "littleTired"
        }
    }

    $scope.almostTired = false;
    $scope.txt_almostTired = {
        bindingOptions: {
            value: "almostTired"
        }
    }

    $scope.veryTired = false;
    $scope.txt_veryTired = {
        bindingOptions: {
            value: "veryTired"
        }
    }

    $scope.exhausted = false;
    $scope.txt_exhausted = {
        bindingOptions: {
            value: "exhausted"
        }
    }




    /////////////////////////////

    $scope.$on('InitFatigueReport', function (event, prms) {

        $scope.tempData = null;



        $scope.tempData = prms;


        $scope.popup_add_visible = true;

    });


}]);