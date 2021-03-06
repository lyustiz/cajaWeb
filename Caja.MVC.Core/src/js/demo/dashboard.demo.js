/*
Template Name: ASPSTUDIO - Responsive Bootstrap 5 Admin Template
Version: 2.3.0
Author: Sean Ngu
Website: http://www.seantheme.com/asp-studio/
*/

var handleChart = function() {
	var series = {
		'monthDataSeries1': {
			'prices': [
				8107, 8128, 8122, 8165, 8340, 8423, 8423, 8514, 8481, 8487, 
				8506, 8626, 8668, 8602, 8607, 8512, 8496, 8600, 8881, 9340
			],
			'dates': [
				'13 Nov 2021', '14 Nov 2021', '15 Nov 2021', '16 Nov 2021',
				'17 Nov 2021', '20 Nov 2021', '21 Nov 2021', '22 Nov 2021',
				'23 Nov 2021', '24 Nov 2021', '27 Nov 2021', '28 Nov 2021',
				'29 Nov 2021', '30 Nov 2021', '01 Dec 2021', '04 Dec 2021', 
				'05 Dec 2021', '06 Dec 2021', '07 Dec 2021', '08 Dec 2021'
			]
		}
	};
	var options = {
		series: [{
			data: [
				8107, 8128, 8122, 8165, 8340, 8423, 8423, 8514, 8481, 8487, 
				8506, 8626, 8668, 8602, 8607, 8512, 8496, 8600, 8881, 9340
			]
		}],
		labels: [
			'13 Nov 2021', '14 Nov 2021', '15 Nov 2021', '16 Nov 2021',
			'17 Nov 2021', '20 Nov 2021', '21 Nov 2021', '22 Nov 2021',
			'23 Nov 2021', '24 Nov 2021', '27 Nov 2021', '28 Nov 2021',
			'29 Nov 2021', '30 Nov 2021', '01 Dec 2021', '04 Dec 2021', 
			'05 Dec 2021', '06 Dec 2021', '07 Dec 2021', '08 Dec 2021'
		],
		colors: [COLOR_BLUE],
		chart: {
			height: 256,
			type: 'line',
			toolbar: {
				show: false
			}
		},
		annotations: {
			yaxis: [{
				y: 8200,
				borderColor: COLOR_INDIGO,
				label: {
					borderColor: COLOR_INDIGO,
					style: {
						color: COLOR_WHITE,
						background: COLOR_INDIGO,
					},
					text: 'Support',
				}
			}, {
				y: 8600,
				y2: 9000,
				borderColor: COLOR_ORANGE,
				fillColor: COLOR_ORANGE,
				opacity: 0.1,
				label: {
					borderColor: COLOR_YELLOW,
					style: {
						fontSize: '10px',
						color: COLOR_GRAY_900,
						background: COLOR_YELLOW,
					},
					text: 'Earning',
				}
			}],
			xaxis: [{
				x: new Date('23 Nov 2021').getTime(),
				strokeDashArray: 0,
				borderColor: COLOR_GRAY_900,
				label: {
					borderColor: COLOR_GRAY_900,
					style: {
						color: COLOR_WHITE,
						background: COLOR_GRAY_900,
					},
					text: 'Anno Test',
				}
			}, {
				x: new Date('26 Nov 2021').getTime(),
				x2: new Date('28 Nov 2021').getTime(),
				fillColor: COLOR_TEAL,
				opacity: 0.4,
				label: {
					borderColor: COLOR_TEAL,
					style: {
						fontSize: '10px',
						color: '#fff',
						background: COLOR_TEAL,
					},
					offsetY: -7,
					text: 'X-axis range',
				}
			}],
			points: [{
				x: new Date('01 Dec 2021').getTime(),
				y: 8607.55,
				marker: {
					size: 8,
					fillColor: COLOR_WHITE,
					strokeColor: COLOR_PINK,
					radius: 2
				},
				label: {
					borderColor: COLOR_PINK,
					offsetY: 0,
					style: {
						color: COLOR_WHITE,
						background: COLOR_PINK,
					},

					text: 'Point Annotation',
				}
			}]
		},
		dataLabels: {
			enabled: false
		},
		stroke: {
			curve: 'straight'
		},
		grid: {
			padding: {
				right: 30,
				left: 20
			}
		},
		xaxis: {
			type: 'datetime',
		},
	};

	var chart = new ApexCharts(document.querySelector('#chart'), options);
	chart.render();
};


/* Controller
------------------------------------------------ */
$(document).ready(function() {
	handleChart();
});